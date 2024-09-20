namespace AssetTool
{
    public static class StructWriter
    {
        public static bool RebuildAsset(string arg)
        {
            string[] args = [$"Data/Input/{arg}.uasset", $"Data/Output/{arg}.json", $"Data/Output/{arg}.uasset"];
            (string InAssetPath, string OutJsonPath, string OutAssetPath) = (args[0], args[1], args[2]);
            bool success = false;
            StructAsset asset = new StructAsset();
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
                success = reader.Read(asset);
                if (!success) break;
                #endregion

                #region Write Intermediate
                using MemoryStream stream1 = new();
                using BinaryWriter writer1 = new BinaryWriter(stream1);
                GlobalObjects.Transfer = new TransferWriter(writer1);
                writer1.Write(asset);
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
                GlobalObjects.Transfer = new TransferWriter(writer2);
                writer2.Write(asset.ToJsonThenToObject());
                stream2.Position = 0;
                outputBytes2 = stream2.ToArray();
                #endregion

                #region Compare Output
                success = DataComparer.CompareBytes(inputBytes, outputBytes2, 0);
                if (!success) break;
                #endregion

                #region Saving Files
                Directory.CreateDirectory(Path.GetDirectoryName(OutAssetPath));
                File.WriteAllBytes(OutAssetPath, outputBytes2);
                asset.SaveToJson(OutJsonPath);
                #endregion
            }

            return success;
        }

        public static bool RebuildAssetFast(string InAssetPath, string tempDir = null)
        {
            bool success = false;
            string outputDir = null;
            StructAsset asset = new StructAsset();
            byte[] outputBytes1 = null;
            byte[] outputBytes2 = null;
            int i = 0;

            if (tempDir is { })
            {
                string subDir = Path.GetDirectoryName(InAssetPath).Replace(Path.GetPathRoot(InAssetPath), "");
                outputDir = Path.Combine(tempDir, subDir);
                Directory.CreateDirectory(outputDir);
            }

            while (i++ == 0)
            {
                #region Read Input
                byte[] inputBytes = File.ReadAllBytes(InAssetPath);
                using MemoryStream inputStream = new MemoryStream(inputBytes, 0, inputBytes.Length, false, true);
                using BinaryReader reader = new BinaryReader(inputStream);
                GlobalObjects.Transfer = new TransferReader(reader);
                success = reader.Read(asset);
                #endregion

                #region Write Intermediate
                using MemoryStream stream1 = new();
                using BinaryWriter writer1 = new BinaryWriter(stream1);
                GlobalObjects.Transfer = new TransferWriter(writer1);
                writer1.Write(asset);
                stream1.Position = 0;
                outputBytes1 = stream1.ToArray();
                #endregion

                if (!success) break;

                #region Compare Intermediate
                success = DataComparer.CompareBytes(inputBytes, outputBytes1, 0);
                if (!success) break;
                outputBytes1 = null;
                #endregion

                #region Write Output
                using MemoryStream stream2 = new();
                using BinaryWriter writer2 = new BinaryWriter(stream2);
                GlobalObjects.Transfer = new TransferWriter(writer2);
                writer2.Write(asset.ToJsonThenToObject());
                stream2.Position = 0;
                outputBytes2 = stream2.ToArray();
                #endregion

                #region Compare Output
                success = DataComparer.CompareBytes(inputBytes, outputBytes2, 0);
                if (!success) break;
                #endregion
            }

            if (tempDir is { })
            {
                string outputJson = Path.Combine(outputDir, $"{Path.GetFileNameWithoutExtension(InAssetPath)}.json");
                asset.SaveToJson(outputJson);

                string outputBinary = Path.Combine(outputDir, Path.GetFileName(InAssetPath));
                File.WriteAllBytes(outputBinary, outputBytes2 ?? outputBytes1 ?? []);
            }

            return success;
        }
    }
}
