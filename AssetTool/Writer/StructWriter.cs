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
                using var writer2 = new BinaryWriter(File.Open(OutAssetPath, FileMode.Create));
                writer2.Write(stream1.ToArray());

                if (!success)
                {
                    return false;
                }

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
            }

            if (!DataComparer.CompareFiles(InAssetPath, OutAssetPath))
            {
                asset2.SaveToJson(OutJsonPath.Replace(".json", "2.json"));
                Log.Info($"\nResult: BinaryWriter failed\n");
                return false;
            }

            return true;
        }

        public static bool RebuildAssetInMemory(string arg)
        {
            var InAssetPath = $"Data/Input/{arg}.uasset";

            // reading original BINARY file into object
            using FileStream fileStream = new(InAssetPath, FileMode.Open);
            using BinaryReader reader = new(fileStream);
            GlobalObjects.Transfer = new TransferReader(reader);
            var asset = new StructAsset();
            bool success = reader.Read(asset);
            if (!success)
                return false;

            // reading original BINARY file into Bytes0
            long size = reader.BaseStream.Position;
            reader.BaseStream.Position = 0;
            byte[] bytes0 = new byte[size];
            reader.Read(bytes0);

            // saving object into Bytes1
            using MemoryStream stream1 = new();
            using BinaryWriter writer1 = new(stream1);
            GlobalObjects.Transfer = new TransferWriter(writer1);
            writer1.Write(asset);
            stream1.Position = 0;
            byte[] bytes1 = stream1.ToArray();

            //Comparing Bytes0 and Bytes1
            if (!DataComparer.CompareBytes(bytes0, bytes1, 0))
                return false;

            // reading JSON into object
            string json1 = asset.ToJson();
            StructAsset asset2 = json1.ToObject<StructAsset>();

            // saving object into Bytes2
            using MemoryStream stream2 = new();
            using BinaryWriter writer2 = new BinaryWriter(stream2);
            GlobalObjects.Transfer = new TransferWriter(writer2);
            writer2.Write(asset2);
            stream2.Position = 0;
            byte[] bytes2 = stream2.ToArray();

            //Comparing Bytes0 and Bytes2
            if (!DataComparer.CompareBytes(bytes0, bytes2, 0))
                return false;

            return true;
        }
    }
}
