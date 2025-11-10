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
            long fileLength = new FileInfo(InAssetPath).Length;
            if (fileLength > AppConfig.MaxFileSize)
            {
                Console.WriteLine($"Max File Size Exeeded: {fileLength}. File: {InAssetPath}");
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

        public static bool RunUassetToJson(string inputFile, string outputFile)
        {
            bool success = false;
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
            using MemoryStream stream1 = new();
            using BinaryWriter writer1 = new BinaryWriter(stream1);
            using TransferWriter transferWriter = new TransferWriter(writer1);

            //Read json file
            AssetPackage asset = inputFile.ReadJson<AssetPackage>();
            //Write uasset file
            success = asset.Move(transferWriter, "Writing Export Objects (obj -> uasset)");
            if (!success) return false;

            if (outputFile is { })
                File.WriteAllBytes(outputFile, stream1.ToArray());
            return success;
        }

        #region Individual Calls
        public static bool ReadAsset(string InAssetPath)
        {
            AssetPackage asset = new AssetPackage();
            long fileLength = new FileInfo(InAssetPath).Length;
            if (fileLength > AppConfig.MaxFileSize) return true;
            byte[] inputBytes = File.ReadAllBytes(InAssetPath);
            using MemoryStream inputStream = new MemoryStream(inputBytes, 0, inputBytes.Length, false, true);
            using BinaryReader reader = new BinaryReader(inputStream);
            using TransferReader transferReader = new TransferReader(reader);
            transferReader.GlobalObjects.FileName = InAssetPath;
            return asset.Move(transferReader, "Reading");
        }

        public static async Task<bool> ReadAssetAsync(string InAssetPath)
        {
            AssetPackage asset = new AssetPackage();
            long fileLength = new FileInfo(InAssetPath).Length;
            if (fileLength > AppConfig.MaxFileSize) return true;
            byte[] inputBytes = await File.ReadAllBytesAsync(InAssetPath);
            using MemoryStream inputStream = new MemoryStream(inputBytes, 0, inputBytes.Length, false, true);
            using BinaryReader reader = new BinaryReader(inputStream);
            using TransferReader transferReader = new TransferReader(reader);
            transferReader.GlobalObjects.FileName = InAssetPath;
            return await asset.MoveAsync(transferReader, "Reading");
        }
        #endregion
    }
}
