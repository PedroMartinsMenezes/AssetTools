using System.Globalization;

namespace AssetTool
{
    public static class AssetConverter
    {
        public static AppConfig AppConfig { get; set; }

        static AssetConverter()
        {
            var cultureInfo = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        }

        public static bool RebuildAssetFast(string InAssetPath, string outDir = null, FileVersion fileVersion = null)
        {
            if (!File.Exists(InAssetPath))
            {
                Console.WriteLine($"File not found: {InAssetPath}");
                return false;
            }
            if (AppConfig is null)
            {
                throw new InvalidOperationException("AppConfig is not initialized. Please call AssetConverter.Initialize() before using this method.");
            }
            bool success = false;
            AssetPackage asset = new AssetPackage();
            byte[] outputBytes2 = default;
            int i = 0;
            FileInfo fileInfo = new FileInfo(InAssetPath);
            InAssetPath = fileInfo.FullName;
            long fileLength = fileInfo.Length;
            if (fileLength > AppConfig.MaxFileSize)
            {
                Log.Info($"Max File Size Exeeded: {fileLength}. File: {InAssetPath}");
                return true;
            }
            if (!string.IsNullOrEmpty(outDir))
            {
                string inputDir = string.IsNullOrEmpty(Path.GetDirectoryName(InAssetPath)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(InAssetPath);
                string subDir = inputDir.Replace(Path.GetPathRoot(InAssetPath), "");
                Directory.CreateDirectory(outDir);
                Directory.CreateDirectory(Path.Combine(outDir, "json", subDir));
                Directory.CreateDirectory(Path.Combine(outDir, "data", subDir));
            }

            using FileStream inputStream = new FileStream(InAssetPath, FileMode.Open, FileAccess.Read);
            using BinaryReader reader = new BinaryReader(inputStream);
            using Transfer transferReader = new TransferReader(reader, AppConfig);
            transferReader.GlobalObjects.FileName = InAssetPath;
            transferReader.GlobalObjects.FileSize = (int)fileLength;
            transferReader.GlobalObjects.FileVersion = fileVersion;

            while (i++ == 0)
            {
                #region Read Input
                success = asset.Move(transferReader, "Reading");
                if (asset.VersionIsTooOld)
                {
                    Console.WriteLine($"Version is too old: {InAssetPath}");
                    return true;
                }
                if (!success) break;
                #endregion

                #region Write Output
                using MemoryStream outputStream = new();
                using BinaryWriter writer2 = new BinaryWriter(outputStream);
                using TransferWriter transferWriter2 = new TransferWriter(writer2, transferReader, true);
                success = asset.ToJsonThenToObjectThenMoveAsync(transferWriter2, "Writing").GetAwaiter().GetResult();
                if (!success) break;
                #endregion

                #region Compare Output
                success = DataComparer.CompareStreams(inputStream, outputStream, asset.Length) is string msg1 && msg1.Length == 0;
                #endregion
            }

            if (!string.IsNullOrEmpty(outDir))
            {
                string inputDir = string.IsNullOrEmpty(Path.GetDirectoryName(InAssetPath)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(InAssetPath);
                string subDir = inputDir.Replace(Path.GetPathRoot(InAssetPath), "");

                string outputJson = Path.Combine(outDir, "json", subDir, $"{Path.GetFileNameWithoutExtension(InAssetPath)}.json");
                asset.SaveToJson(outputJson, transferReader);

                string outputBinary = Path.Combine(outDir, "data", subDir, Path.GetFileName(InAssetPath));
                File.WriteAllBytes(outputBinary, outputBytes2);
            }

            if (AppConfig.DebugSaveUnitTest)
            {
                if (InAssetPath.Contains("\\Data\\Input\\"))
                {
                    string ext = Path.GetExtension(InAssetPath);
                    string[] parts = InAssetPath.Split("\\Data\\Input\\");
                    string inputDir = parts[0] + "\\Data\\Input\\";
                    string outputDir = parts[0] + "\\Data\\Output\\";
                    string outputFile = Path.Combine(outputDir, Path.GetRelativePath(inputDir, InAssetPath)).Replace(ext, ".json");
                    asset.SaveToJson(outputFile, transferReader);
                }
                else if (InAssetPath.Contains("\\Data\\InputCooked\\"))
                {
                    string ext = Path.GetExtension(InAssetPath);
                    string[] parts = InAssetPath.Split("\\Data\\InputCooked\\");
                    string inputDir = parts[0] + "\\Data\\InputCooked\\";
                    string outputDir = parts[0] + "\\Data\\OutputCooked\\";
                    string outputFile = Path.Combine(outputDir, Path.GetRelativePath(inputDir, InAssetPath)).Replace(ext, ".json");
                    asset.SaveToJson(outputFile, transferReader);
                }
            }

            return success;
        }

        #region RunUassetToJson
        public static (string, byte[]) RunUassetToJson(string inputFile, string outputFile)
        {
            bool success = false;
            AssetPackage asset = new AssetPackage();

            if (!string.IsNullOrEmpty(outputFile))
            {
                string outputDir = string.IsNullOrEmpty(Path.GetDirectoryName(outputFile)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(outputFile);
                Directory.CreateDirectory(outputDir);
                if (outputFile.Equals(inputFile, StringComparison.OrdinalIgnoreCase))
                {
                    outputFile = Path.Combine(outputDir, $"{Path.GetFileNameWithoutExtension(inputFile)}.json");
                }
            }

            //Read uasset file
            byte[] inputBytes = File.ReadAllBytes(inputFile);
            using MemoryStream inputStream = new MemoryStream(inputBytes, 0, inputBytes.Length, false, true);
            using BinaryReader reader = new BinaryReader(inputStream);
            using TransferReader transferReader = new TransferReader(reader, AppConfig);
            success = asset.Move(transferReader, "Reading Export Objects (uasset -> obj)");
            if (!success)
                return (null, null);

            //Write uasset to json
            string json = asset.ToJson();

            //Write json file
            if (!string.IsNullOrEmpty(outputFile))
            {
                File.WriteAllText(outputFile, json);
            }

            return (json, inputBytes);
        }

        public static bool RunUassetToJsonFiles(string inputDir, string outputDir, bool exitOnError)
        {
            string[] inputFiles = Directory.GetFiles(inputDir, "*.uasset", SearchOption.AllDirectories);
            foreach (string inputFile in inputFiles)
            {
                string outputFile = Path.Combine(outputDir, Path.GetRelativePath(inputDir, inputFile)).Replace(".uasset", ".json");
                (string json, _) = RunUassetToJson(inputFile, outputFile);
                if (json is null)
                {
                    Log.Error($"Failed to convert {inputFile} to {outputFile}");
                    if (exitOnError)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #region RunJsonToUasset
        public static byte[] RunJsonToUasset(string inputFile, string outputFile)
        {
            AssetPackage asset = null;
            if (!string.IsNullOrEmpty(outputFile))
            {
                string outputDir = string.IsNullOrEmpty(Path.GetDirectoryName(outputFile)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(outputFile);
                Directory.CreateDirectory(outputDir);
                if (outputFile.Equals(inputFile, StringComparison.OrdinalIgnoreCase))
                {
                    outputFile = Path.Combine(outputDir, inputFile.NameWithExtension());
                }
                //Read json file
                asset = inputFile.ReadJson<AssetPackage>();
            }
            else
            {
                //Read json content
                asset = inputFile.ToObject<AssetPackage>();
            }

            //Write uasset to byte array
            using MemoryStream stream1 = new();
            using BinaryWriter writer1 = new BinaryWriter(stream1);
            using TransferWriter transferWriter = new TransferWriter(writer1, fromJson: true);
            bool success = asset.Move(transferWriter, "Writing Export Objects (obj -> uasset)");
            if (!success)
                return [];
            byte[] bytes = stream1.ToArray();

            //Write uasset to file
            if (!string.IsNullOrEmpty(outputFile))
            {
                File.WriteAllBytes(outputFile, bytes);
            }

            return bytes;
        }

        public static bool RunJsonToUassetFiles(string inputDir, string outputDir, bool exitOnError)
        {
            string[] inputFiles = Directory.GetFiles(inputDir, "*.json", SearchOption.AllDirectories);
            foreach (string inputFile in inputFiles)
            {
                string outputFile = Path.Combine(outputDir, Path.GetRelativePath(inputDir, inputFile)).Replace(".json", ".uasset");
                byte[] bytes = RunJsonToUasset(inputFile, outputFile);
                if (bytes.Length == 0)
                {
                    Log.Error($"Failed to convert {inputFile} to {outputFile}");
                    if (exitOnError)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        public static bool IsAssetType(string InAssetPath, string assetType)
        {
            AssetPackage asset = new AssetPackage();
            using FileStream inputStream = new FileStream(InAssetPath, FileMode.Open, FileAccess.Read);
            using BinaryReader reader = new BinaryReader(inputStream);
            using Transfer transferReader = new TransferReader(reader, AppConfig);
            transferReader.GlobalObjects.FileName = InAssetPath;
            return asset.IsAssetType(transferReader, assetType);
        }

        public static string GetAssetType(string InAssetPath)
        {
            AssetPackage asset = new AssetPackage();
            using FileStream inputStream = new FileStream(InAssetPath, FileMode.Open, FileAccess.Read);
            using BinaryReader reader = new BinaryReader(inputStream);
            using Transfer transferReader = new TransferReader(reader, AppConfig);
            transferReader.GlobalObjects.FileName = InAssetPath;
            return asset.GetAssetType(transferReader);
        }
    }
}
