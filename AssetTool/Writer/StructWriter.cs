namespace AssetTool
{
    public static class StructWriter
    {
        public const string Path = "C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco2.dat";
        public const string PathExpected = "C:\\UE\\IntroProjectCpp\\Content\\Lab\\S_Endereco.uasset";

        public static void SaveStruct()
        {
            Read_StructHeader_From_Asset();
        }

        public static void Read_StructHeader_From_Asset()
        {
            string path = "Data/S_Endereco.uasset";
            using var fileStream = new FileStream(path, FileMode.Open);
            using var reader = new BinaryReader(fileStream);
            var asset = new StructHeader();

            reader.Read(asset);

            using var writer = new BinaryWriter(File.Open("C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco2.dat", FileMode.Create));
            writer.Write(asset);

            asset.SaveToJson("C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco.header.json");
        }

        public static void Read_StructHeader_From_Json()
        {
            //reading json
            StructHeader asset = "Data/S_Endereco.header.json".ReadJson<StructHeader>();

            //saving binary
            using var writer = new BinaryWriter(File.Open(Path, FileMode.Create));
            writer.Write(asset);
        }
    }
}
