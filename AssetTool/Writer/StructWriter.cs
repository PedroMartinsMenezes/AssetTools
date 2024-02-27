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

                MemoryStream stream = new();
                BinaryWriter writer1 = new BinaryWriter(stream);

                var asset = new StructAsset();

                // reading original BINARY file
                Log.Info($"Reading asset: {InAssetPath}");
                if (!reader.Read(asset))
                    return false;

                // saving reconstructed BINARY file from original BINARY file
                Log.Info($"\nWriting Asset: {OutAssetPath}\n");
                writer1.Write(asset);
                using var writer2 = new BinaryWriter(File.Open(OutAssetPath, FileMode.Create));
                stream.Position = 0;
                writer2.Write(stream.ToArray());

                // saving JSON from original binary file
                Log.Info($"\nWriting Json: {OutJsonPath}");
                asset.SaveToJson(OutJsonPath);
            }

            if (!DataComparer.CompareFiles(InAssetPath, OutAssetPath))
            {
                Log.Info($"\nResult: BinaryReader failed\n");
                return false;
            }

            StructAsset asset2 = null;
            using (var writer2 = new BinaryWriter(File.Open(OutAssetPath, FileMode.Create)))
            {
                // reading JSON file
                Log.Info($"\nReading Json: {OutJsonPath}");

                asset2 = OutJsonPath.ReadJson<StructAsset>();

                // saving reconstructed BINARY file from original JSON file
                Log.Info($"\nWriting Asset {OutAssetPath} from Json\n");
                writer2.Write(asset2);
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
