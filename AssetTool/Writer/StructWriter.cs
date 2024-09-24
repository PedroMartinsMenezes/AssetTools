namespace AssetTool
{
    public static class StructWriter
    {
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
                GlobalObjects.Transfer = new TransferWriter(writer2);
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
                Directory.CreateDirectory(Path.GetDirectoryName(OutAssetPath));
                File.WriteAllBytes(OutAssetPath, outputBytes2);
                asset.SaveToJson(OutJsonPath);
                #endregion
            }

            return success;
        }

        public static bool RebuildAssetFast(string InAssetPath, string outDir = null)
        {
            bool success = false;
            AssetPackage asset = new AssetPackage();
            byte[] outputBytes1 = null;
            byte[] outputBytes2 = null;
            int i = 0;

            if (outDir is { })
            {
                string subDir = Path.GetDirectoryName(InAssetPath).Replace(Path.GetPathRoot(InAssetPath), "");
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
                GlobalObjects.Transfer = new TransferWriter(writer2);
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

            if (outDir is { })
            {
                string subDir = Path.GetDirectoryName(InAssetPath).Replace(Path.GetPathRoot(InAssetPath), "");

                string outputJson = Path.Combine(outDir, "json", subDir, $"{Path.GetFileNameWithoutExtension(InAssetPath)}.json");
                asset.SaveToJson(outputJson);

                string outputBinary = Path.Combine(outDir, "data", subDir, Path.GetFileName(InAssetPath));
                File.WriteAllBytes(outputBinary, outputBytes2 ?? outputBytes1 ?? []);
            }

            return success;
        }
    }
}
