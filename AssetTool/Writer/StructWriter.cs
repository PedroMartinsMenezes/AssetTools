namespace AssetTool
{
    public static class StructWriter
    {
        [Obsolete("Use the RebuildAssetFast")]
        public static bool RebuildAsset(string arg)
        {
            string[] args = [$"Data/Input/{arg}.uasset", $"Data/Output/{arg}.json", $"Data/Output/{arg}.uasset"];
            (string InAssetPath, string OutJsonPath, string OutAssetPath) = (args[0], args[1], args[2]);
            bool success = false;
            AssetPackage asset = new AssetPackage();
            byte[] outputBytes1 = null;
            byte[] outputBytes2 = null;
            int i = 0;

            while (i++ == 0)
            {
                #region Read Input
                byte[] inputBytes = File.ReadAllBytes(InAssetPath);
                using MemoryStream inputStream = new MemoryStream(inputBytes, 0, inputBytes.Length, false, true);
                using BinaryReader reader = new BinaryReader(inputStream);
                GlobalObjects.Transfer = new TransferReader(reader);
                success = asset.Move(GlobalObjects.Transfer, "Reading Export Objects (uasset -> obj)");
                if (!success) break;
                #endregion

                #region Write Intermediate
                using MemoryStream stream1 = new();
                using BinaryWriter writer1 = new BinaryWriter(stream1);
                GlobalObjects.Transfer = new TransferWriter(writer1);
                success = asset.Move(GlobalObjects.Transfer, "Writing Export Objects (obj -> uasset)");
                if (!success) break;
                stream1.Position = 0;
                outputBytes1 = stream1.ToArray();
                #endregion

                #region Compare Intermediate
                success = DataComparer.CompareBytes(inputBytes, outputBytes1, 0);
                if (!success) break;
                #endregion

                #region Write Output
                using MemoryStream stream2 = new();
                using BinaryWriter writer2 = new BinaryWriter(stream2);
                GlobalObjects.Transfer = new TransferWriter(writer2, true);
                success = asset.ToJsonThenToObject().Move(GlobalObjects.Transfer, "Writing Export Objects (obj -> json -> obj -> uasset)");
                if (!success) break;
                stream2.Position = 0;
                outputBytes2 = stream2.ToArray();
                #endregion

                #region Compare Output
                success = DataComparer.CompareBytes(inputBytes, outputBytes2, 0);
                if (!success) break;
                #endregion

                #region Saving Files
                //string outputDir = string.IsNullOrEmpty(Path.GetDirectoryName(OutAssetPath)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(OutAssetPath);
                //Directory.CreateDirectory(outputDir);
                //File.WriteAllBytes(OutAssetPath, outputBytes2);
                //asset.SaveToJson(OutJsonPath);
                #endregion
            }

            return success;
        }

        public static bool RebuildAssetFast(string InAssetPath, string outDir)
        {
            bool success = false;
            AssetPackage asset = new AssetPackage();
            byte[] outputBytes1 = null;
            byte[] outputBytes2 = null;
            int i = 0;

            if (!string.IsNullOrEmpty(outDir))
            {
                string inputDir = string.IsNullOrEmpty(Path.GetDirectoryName(InAssetPath)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(InAssetPath);
                string subDir = inputDir.Replace(Path.GetPathRoot(InAssetPath), "");
                Directory.CreateDirectory(outDir);
                Directory.CreateDirectory(Path.Combine(outDir, "json", subDir));
                Directory.CreateDirectory(Path.Combine(outDir, "data", subDir));
            }

            while (i++ == 0)
            {
                #region Read Input
                byte[] inputBytes = File.ReadAllBytes(InAssetPath);
                using MemoryStream inputStream = new MemoryStream(inputBytes, 0, inputBytes.Length, false, true);
                using BinaryReader reader = new BinaryReader(inputStream);
                GlobalObjects.Transfer = new TransferReader(reader);
                success = asset.Move(GlobalObjects.Transfer, "Reading");
                if (!success) break;
                #endregion

                #region Write Intermediate
                using MemoryStream stream1 = new();
                using BinaryWriter writer1 = new BinaryWriter(stream1);
                GlobalObjects.Transfer = new TransferWriter(writer1);
                success = asset.Move(GlobalObjects.Transfer, "Writing from Object");
                if (!success) break;
                stream1.Position = 0;
                outputBytes1 = stream1.ToArray();
                #endregion

                #region Compare Intermediate
                success = DataComparer.CompareBytes(inputBytes, outputBytes1, 0);
                if (!success) break;
                outputBytes1 = null;
                #endregion

                #region Write Output
                using MemoryStream stream2 = new();
                using BinaryWriter writer2 = new BinaryWriter(stream2);
                GlobalObjects.Transfer = new TransferWriter(writer2, true);
                success = asset.ToJsonThenToObject().Move(GlobalObjects.Transfer, "Writing from JSON");
                if (!success) break;
                stream2.Position = 0;
                outputBytes2 = stream2.ToArray();
                #endregion

                #region Compare Output
                success = DataComparer.CompareBytes(inputBytes, outputBytes2, 0);
                if (!success) break;
                #endregion
            }

            if (!string.IsNullOrEmpty(outDir))
            {
                string inputDir = string.IsNullOrEmpty(Path.GetDirectoryName(InAssetPath)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(InAssetPath);
                string subDir = inputDir.Replace(Path.GetPathRoot(InAssetPath), "");

                string outputJson = Path.Combine(outDir, "json", subDir, $"{Path.GetFileNameWithoutExtension(InAssetPath)}.json");
                asset.SaveToJson(outputJson);

                string outputBinary = Path.Combine(outDir, "data", subDir, Path.GetFileName(InAssetPath));
                File.WriteAllBytes(outputBinary, outputBytes2 ?? outputBytes1 ?? []);
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
            GlobalObjects.Transfer = new TransferReader(reader);
            success = asset.Move(GlobalObjects.Transfer, "Reading Export Objects (uasset -> obj)");
            if (!success) return false;

            //Write json file
            asset.SaveToJson(outputFile);

            return success;
        }

        public static bool RunJsonToUasset(string inputFile, string outputFile)
        {
            bool success = false;
            string outputDir = string.IsNullOrEmpty(Path.GetDirectoryName(outputFile)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(outputFile);
            Directory.CreateDirectory(outputDir);

            if (outputFile.Equals(inputFile, StringComparison.OrdinalIgnoreCase))
            {
                outputFile = Path.Combine(outputDir, $"{Path.GetFileNameWithoutExtension(inputFile)}.uasset");
            }

            //Read json file
            AssetPackage asset = inputFile.ReadJson<AssetPackage>();

            //Write uasset file
            using MemoryStream stream1 = new();
            using BinaryWriter writer1 = new BinaryWriter(stream1);
            GlobalObjects.Transfer = new TransferWriter(writer1);
            success = asset.Move(GlobalObjects.Transfer, "Writing Export Objects (obj -> uasset)");
            if (!success) return false;

            File.WriteAllBytes(outputFile, stream1.ToArray());
            return success;
        }
    }
}
