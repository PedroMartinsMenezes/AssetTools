namespace AssetTool
{
    public static class StructWriter
    {
        public static void RebuildAsset(string arg)
        {
            string[] args = [$"Data/Input/{arg}.uasset", $"Data/Output/{arg}.json", $"Data/Output/{arg}.uasset"];

            string InAssetPath = args[0];
            string OutJsonPath = args[1];
            string OutAssetPath = args[2];

            using var fileStream = new FileStream(InAssetPath, FileMode.Open);
            using var reader = new BinaryReader(fileStream);

            var asset = new StructAsset();
            // original asset to obj
            reader.Read(asset);
            // obj to json            
            asset.SaveToJson(OutJsonPath);
            // json to asset
            var asset2 = OutJsonPath.ReadJson<StructAsset>();
            using var writer2 = new BinaryWriter(File.Open(OutAssetPath, FileMode.Create));
            writer2.Write(asset2);
        }
    }
}
