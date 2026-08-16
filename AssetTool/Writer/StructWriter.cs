using System.Globalization;

namespace AssetTool
{
    public static class StructWriter
    {
        static StructWriter()
        {
            var cultureInfo = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        }

        public static bool RebuildAssetFast(string InAssetPath, string outDir)
        {
            if (!File.Exists(InAssetPath))
            {
                Console.WriteLine($"File not found: {InAssetPath}");
                return false;
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
            using Transfer transferReader = new TransferReader(reader);
            transferReader.GlobalObjects.FileName = InAssetPath;
            transferReader.GlobalObjects.FileSize = (int)fileLength;

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

            if (AppConfig.DebugSaveUnitTest && InAssetPath.Contains("\\Input\\"))
            {
                string ext = Path.GetExtension(InAssetPath);
                string outputPath = InAssetPath.Replace("\\Input\\", "\\Output\\").Replace(ext, ".json");
                asset.SaveToJson(outputPath, transferReader);
            }

            return success;
        }

        #region RunUassetToJson
        public static bool RunUassetToJson(string inputFile, string outputFile)
        {
            bool success = false;
            outputFile = outputFile ?? inputFile;
            AssetPackage asset = new AssetPackage();
            string outputDir = string.IsNullOrEmpty(Path.GetDirectoryName(outputFile)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(outputFile);
            Directory.CreateDirectory(outputDir);

            if (outputFile.Equals(inputFile, StringComparison.OrdinalIgnoreCase))
            {
                outputFile = Path.Combine(outputDir, $"{Path.GetFileNameWithoutExtension(inputFile)}.json");
            }

            //Read uasset file
            byte[] inputBytes = File.ReadAllBytes(inputFile);
            using MemoryStream inputStream = new MemoryStream(inputBytes, 0, inputBytes.Length, false, true);
            using BinaryReader reader = new BinaryReader(inputStream);
            using TransferReader transferReader = new TransferReader(reader);
            success = asset.Move(transferReader, "Reading Export Objects (uasset -> obj)");
            if (!success) return false;

            //Write json file
            asset.SaveToJson(outputFile, transferReader);

            return success;
        }

        public static bool RunUassetToJsonFiles(string inputDir, string outputDir, bool exitOnError)
        {
            string[] inputFiles = Directory.GetFiles(inputDir, "*.uasset", SearchOption.AllDirectories);
            foreach (string inputFile in inputFiles)
            {
                string outputFile = Path.Combine(outputDir, Path.GetRelativePath(inputDir, inputFile)).Replace(".uasset", ".json");
                bool success = StructWriter.RunUassetToJson(inputFile, outputFile);
                if (!success)
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
        public static bool RunJsonToUasset(string inputFile, string outputFile = null)
        {
            bool success = false;
            string outputDir = string.IsNullOrEmpty(Path.GetDirectoryName(outputFile)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(outputFile);
            if (outputFile is { })
            {
                Directory.CreateDirectory(outputDir);
                if (outputFile.Equals(inputFile, StringComparison.OrdinalIgnoreCase))
                {
                    outputFile = Path.Combine(outputDir, inputFile.NameWithExtension());
                }
            }

            //Read json file
            AssetPackage asset = inputFile.ReadJson<AssetPackage>();

            //Write uasset file
            using MemoryStream stream1 = new();
            using BinaryWriter writer1 = new BinaryWriter(stream1);
            using TransferWriter transferWriter = new TransferWriter(writer1);
            success = asset.Move(transferWriter, "Writing Export Objects (obj -> uasset)");
            if (!success) return false;

            if (outputFile is { })
                File.WriteAllBytes(outputFile, stream1.ToArray());
            return success;
        }

        public static bool RunJsonToUassetFiles(string inputDir, string outputDir, bool exitOnError)
        {
            string[] inputFiles = Directory.GetFiles(inputDir, "*.json", SearchOption.AllDirectories);
            foreach (string inputFile in inputFiles)
            {
                string outputFile = Path.Combine(outputDir, Path.GetRelativePath(inputDir, inputFile)).Replace(".json", ".uasset");
                bool success = StructWriter.RunJsonToUasset(inputFile, outputFile);
                if (!success)
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
            using Transfer transferReader = new TransferReader(reader);
            transferReader.GlobalObjects.FileName = InAssetPath;
            return asset.IsAssetType(transferReader, assetType);
        }

        public static string GetAssetType(string InAssetPath)
        {
            AssetPackage asset = new AssetPackage();
            using FileStream inputStream = new FileStream(InAssetPath, FileMode.Open, FileAccess.Read);
            using BinaryReader reader = new BinaryReader(inputStream);
            using Transfer transferReader = new TransferReader(reader);
            transferReader.GlobalObjects.FileName = InAssetPath;
            return asset.GetAssetType(transferReader);
        }
    }
}
