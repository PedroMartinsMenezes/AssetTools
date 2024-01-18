namespace AssetTool
{
    public static class StructWriter
    {
        public static void RebuildStructAsset(string[] args)
        {
            string InAssetPath = args.Length > 0 ? args[0] : "Data/Input/S_Endereco.uasset";
            string OutJsonPath = args.Length > 1 ? args[1] : "Data/Output/S_Endereco.json";
            string TempAssetPath = args.Length > 2 ? args[2] : "Data/Temp/S_Endereco.uasset";
            string OutAssetPath = args.Length > 3 ? args[3] : "Data/Output/S_Endereco.uasset";

            using var fileStream = new FileStream(InAssetPath, FileMode.Open);
            using var reader = new BinaryReader(fileStream);

            var asset = new StructAsset();
            // original asset to obj
            reader.Read(asset);
            // obj to json            
            asset.SaveToJson(OutJsonPath);
            // obj to asset
            using var writer = new BinaryWriter(File.Open(TempAssetPath, FileMode.Create));
            writer.Write(asset);
            // json to asset
            var asset2 = OutJsonPath.ReadJson<StructAsset>();
            using var writer2 = new BinaryWriter(File.Open(OutAssetPath, FileMode.Create));
            writer2.Write(asset2);
        }

        public static void RebuildBlueprintAsset(string[] args)
        {
            string InAssetPath = args.Length > 0 ? args[0] : "Data/Input/BP_ThirdPersonCharacter.uasset";
            string OutJsonPath = args.Length > 1 ? args[1] : "Data/Output/BP_ThirdPersonCharacter.json";
            //string TempAssetPath = args.Length > 2 ? args[2] : "Data/Temp/BP_ThirdPersonCharacter.uasset";
            string OutAssetPath = args.Length > 3 ? args[3] : "Data/Output/BP_ThirdPersonCharacter.uasset";

            using var fileStream = new FileStream(InAssetPath, FileMode.Open);
            using var reader = new BinaryReader(fileStream);

            var asset = new StructAsset();
            // original asset to obj
            reader.Read(asset);
            // obj to json            
            asset.SaveToJson(OutJsonPath);
            // obj to asset
            //using var writer = new BinaryWriter(File.Open(TempAssetPath, FileMode.Create));
            //writer.Write(asset);
            // json to asset
            //var asset2 = OutJsonPath.ReadJson<StructAsset>();
            using var writer2 = new BinaryWriter(File.Open(OutAssetPath, FileMode.Create));
            //writer2.Write(asset2);
        }
    }
}
