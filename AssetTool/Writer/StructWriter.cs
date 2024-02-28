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

                using MemoryStream stream1 = new();
                BinaryWriter writer1 = new BinaryWriter(stream1);

                var asset = new StructAsset();

                // reading original BINARY file
                Log.Info($"Reading asset: {InAssetPath}");
                if (!reader.Read(asset))
                    return false;

                // saving reconstructed BINARY file from original BINARY file
                Log.Info($"\nWriting Asset: {OutAssetPath}\n");
                writer1.Write(asset);
                stream1.Position = 0;
                using var writer2 = new BinaryWriter(File.Open(OutAssetPath, FileMode.Create));
                writer2.Write(stream1.ToArray());

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
                writer3.Write(asset2);
                using var writer4 = new BinaryWriter(File.Open(OutAssetPath, FileMode.Create));
                writer4.Write(stream2.ToArray());
            }

            if (!DataComparer.CompareFiles(InAssetPath, OutAssetPath))
            {
                asset2.SaveToJson(OutJsonPath.Replace(".json", "2.json"));
                Log.Info($"\nResult: BinaryWriter failed\n");
                return false;
            }

            return true;
        }
    }
}
