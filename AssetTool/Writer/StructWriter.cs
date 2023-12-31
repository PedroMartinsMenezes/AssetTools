namespace AssetTool
{
    public static class StructWriter
    {
        public static string Path = "C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco2.dat";
        public static string PathExpected = "C:\\UE\\IntroProjectCpp\\Content\\Lab\\S_Endereco.uasset";

        public static void SaveStruct()
        {
            var writer = new BinaryWriter(File.Open(Path, FileMode.Create));
            try
            {
                //reading json
                StructHeader asset = "Data/S_Endereco.header.json".ReadJson<StructHeader>();

                //saving binary
                writer.Write(asset);
            }
            finally
            {
                writer.Close();
            }
        }
    }
}
