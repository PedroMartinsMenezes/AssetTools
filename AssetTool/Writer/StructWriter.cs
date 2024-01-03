namespace AssetTool
{
    public static class StructWriter
    {
        public const string Path = "C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco2.dat";
        public const string PathExpected = "C:\\UE\\IntroProjectCpp\\Content\\Lab\\S_Endereco.uasset";

        public static void SaveStruct()
        {
            Recreate_Asset();
        }

        public static void Recreate_Asset()
        {
            string path = "Data/S_Endereco.uasset";
            using var fileStream = new FileStream(path, FileMode.Open);
            using var reader = new BinaryReader(fileStream);

            var asset = new StructAsset();
            // original asset to obj
            reader.Read(asset);
            // obj to json            
            asset.SaveToJson("C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco.json");
            // obj to asset
            using var writer = new BinaryWriter(File.Open("C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco2.dat", FileMode.Create));
            writer.Write(asset);
            // json to asset
            var asset2 = "C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco.json".ReadJson<StructAsset>();
            using var writer2 = new BinaryWriter(File.Open("C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco3.dat", FileMode.Create));
            writer2.Write(asset2);
        }
    }
}
