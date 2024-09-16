namespace AssetTool
{
    public static class StructWriter
    {
        public static bool RebuildAsset(string arg)
        {
            string[] args = [$"Data/Input/{arg}.uasset", $"Data/Output/{arg}.json", $"Data/Output/{arg}.uasset"];

            (string InAssetPath, string OutJsonPath, string OutAssetPath) = (args[0], args[1], args[2]);

            using (var fileStream = new FileStream(InAssetPath, FileMode.Open))
            {
                using var reader = new BinaryReader(fileStream);
                GlobalObjects.Transfer = new TransferReader(reader);

                using MemoryStream stream1 = new();
                BinaryWriter writer1 = new BinaryWriter(stream1);

                var asset = new StructAsset();

                // reading original BINARY file
                Log.Info($"Reading asset: {InAssetPath}");
                bool success = reader.Read(asset);
                if (!success)
                {
                    asset.SaveToJson(OutJsonPath);
                }

                // saving reconstructed BINARY file from original BINARY file
                Log.Info($"\nWriting Asset: {OutAssetPath}\n");
                GlobalObjects.Transfer = new TransferWriter(writer1);
                writer1.Write(asset);
                stream1.Position = 0;
                if (!Directory.Exists(Path.GetDirectoryName(OutAssetPath)))
                    Directory.CreateDirectory(Path.GetDirectoryName(OutAssetPath));
                using var writer2 = new BinaryWriter(File.Open(OutAssetPath, FileMode.Create));
                writer2.Write(stream1.ToArray());
                stream1.Close();
                writer1.Close();
                writer2.Close();

                // saving JSON from original binary file
                Log.Info($"\nWriting Json: {OutJsonPath}");
                asset.SaveToJson(OutJsonPath);
            }

            if (!DataComparer.CompareFiles(InAssetPath, OutAssetPath))
            {
                Log.Info($"\nResult: BinaryReader failed\n");
                return false;
            }

            // reading JSON file
            Log.Info($"\nReading Json: {OutJsonPath}");

            StructAsset asset2 = OutJsonPath.ReadJson<StructAsset>();

            // saving reconstructed BINARY file from original JSON file
            Log.Info($"\nWriting Asset {OutAssetPath} from Json\n");
            using (MemoryStream stream2 = new())
            {
                using BinaryWriter writer3 = new BinaryWriter(stream2);
                GlobalObjects.Transfer = new TransferWriter(writer3);
                writer3.Write(asset2);
                using var writer4 = new BinaryWriter(File.Open(OutAssetPath, FileMode.Create));
                writer4.Write(stream2.ToArray());
                writer4.Close();
                writer3.Close();
                stream2.Close();
            }

            if (!DataComparer.CompareFiles(InAssetPath, OutAssetPath))
            {
                asset2.SaveToJson(OutJsonPath.Replace(".json", "2.json"));
                Log.Info($"\nResult: BinaryWriter failed\n");
                return false;
            }

            return true;
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
