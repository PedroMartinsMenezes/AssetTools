using System.ComponentModel;
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

        [Description("Used Only by Unit Tests")]
        public static bool RebuildAsset(string arg)
        {
            string[] args = [$"Data/Input/{arg}.uasset", $"Data/Output/{arg}.json", $"Data/Output/{arg}.uasset"];
            string InAssetPath = args[0];
            string InAssetPathExp = args[0].Replace(".uasset", ".uexp");
            bool success = false;
            AssetPackage asset = new AssetPackage();
            byte[] outputBytes2 = default;
            int i = 0;

            byte[] inputBytes = File.ReadAllBytes(InAssetPath);
            if (File.Exists(InAssetPathExp))
            {
                inputBytes = inputBytes.Concat(File.ReadAllBytes(InAssetPathExp)).ToArray();
            }
            using MemoryStream inputStream = new MemoryStream(inputBytes, 0, inputBytes.Length, false, true);
            using BinaryReader reader = new BinaryReader(inputStream);
            using TransferReader transferReader = new TransferReader(reader);
            transferReader.GlobalObjects.FileName = InAssetPath;

            while (i++ == 0)
            {
                #region Read Input
                success = asset.Move(transferReader, "Reading (uasset -> obj)");
                if (!success) break;
                #endregion

                #region Write Output
                bool debugSaveMember = AppConfig.DebugSaveMember;
                AppConfig.DebugSaveMember = false;
                using MemoryStream stream2 = new();
                using BinaryWriter writer2 = new BinaryWriter(stream2);
                using TransferWriter transferWriter2 = new TransferWriter(writer2, transferReader, true);
                success = asset.ToJsonThenToObjectThenMove(transferWriter2, "Writing");
                AppConfig.DebugSaveMember = debugSaveMember;

                if (!success) break;
                stream2.Position = 0;
                outputBytes2 = stream2.ToArray();
                #endregion

                #region Compare Output
                success = DataComparer.CompareBytes2(inputBytes, outputBytes2, 0) is string msg1 && msg1.Length == 0;
                #endregion

                #region Saving Files
                if (AppConfig.DebugSaveUnitTest) asset.SaveToJson(args[1], transferReader);
                #endregion
            }

            return success;
        }

        public static bool RebuildAssetFast(string InAssetPath, string outDir)
        {
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
            Transfer transferReader = new TransferReader(reader);
            transferReader.GlobalObjects.FileName = InAssetPath;

            while (i++ == 0)
            {
                #region Read Input
                success = asset.Move(transferReader, "Reading");
                if (!success) break;
                #endregion

                #region Write Output
                using MemoryStream outputStream = new();
                using BinaryWriter writer2 = new BinaryWriter(outputStream);
                using TransferWriter transferWriter2 = new TransferWriter(writer2, transferReader, true);
                success = asset.ToJsonThenToObjectThenMove(transferWriter2, "Writing");
                if (!success) break;
                #endregion

                #region Compare Output
                success = DataComparer.CompareStreams(inputStream, outputStream) is string msg1 && msg1.Length == 0;
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

            return success;
        }

        public static async Task<bool> RebuildAssetFastAsync(string InAssetPath, string outDir)
        {
            if (!File.Exists(InAssetPath))
            {
                Console.WriteLine($"File not found: {InAssetPath}");
                return true;
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

            byte[] inputBytes = await File.ReadAllBytesAsync(InAssetPath);
            using MemoryStream inputStream = new MemoryStream(inputBytes, 0, inputBytes.Length, false, true);
            using BinaryReader reader = new BinaryReader(inputStream);
            using TransferReader transferReader = new TransferReader(reader);
            transferReader.GlobalObjects.FileName = InAssetPath;

            while (i++ == 0)
            {
                #region Read Input
                success = await asset.MoveAsync(transferReader, "Reading");
                if (!success) break;
                #endregion

                #region Write Output
                using MemoryStream outputStream = new();
                using BinaryWriter writer2 = new BinaryWriter(outputStream);
                using TransferWriter transferWriter2 = new TransferWriter(writer2, transferReader, true);
                success = await asset.ToJsonThenToObjectThenMoveAsync(transferWriter2, "Writing");
                if (!success) break;
                outputStream.Position = 0;
                #endregion

                #region Compare Output
                outputBytes2 = outputStream.ToArray();
                string msg1 = DataComparer.CompareBytes2(inputBytes, outputBytes2, 0);
                if (msg1.Length > 0) Console.WriteLine(msg1);
                success = msg1.Length == 0;
                #endregion
            }

            if (!string.IsNullOrEmpty(outDir))
            {
                string inputDir = string.IsNullOrEmpty(Path.GetDirectoryName(InAssetPath)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(InAssetPath);
                string subDir = inputDir.Replace(Path.GetPathRoot(InAssetPath), "");

                string outputJson = Path.Combine(outDir, "json", subDir, $"{Path.GetFileNameWithoutExtension(InAssetPath)}.json");
                asset.SaveToJson(outputJson, transferReader);

                string outputBinary = Path.Combine(outDir, "data", subDir, Path.GetFileName(InAssetPath));
                await File.WriteAllBytesAsync(outputBinary, outputBytes2 ?? []);
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
                    outputFile = Path.Combine(outputDir, $"{Path.GetFileNameWithoutExtension(inputFile)}.uasset");
                }
            }
            using MemoryStream stream1 = new();
            using BinaryWriter writer1 = new BinaryWriter(stream1);
            using TransferWriter transferWriter = new TransferWriter(writer1);

            //Read json file
            AssetPackage asset = inputFile.ReadJson<AssetPackage>(transferWriter);
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
