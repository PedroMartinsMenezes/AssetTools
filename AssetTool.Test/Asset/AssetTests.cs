namespace AssetTool.Test
{
    public class StructTestExperiment
    {
        [Fact]
        public void Read_StructHeader_From_Asset()
        {
            string path = "Data/S_Endereco.uasset";
            using var fileStream = new FileStream(path, FileMode.Open);
            using var reader = new BinaryReader(fileStream);
            var asset = new StructHeader();

            reader.Read(asset);

            using var writer = new BinaryWriter(File.Open("C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco2.dat", FileMode.Create));
            writer.Write(asset);

            //asset.SaveToJson("C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco.header.json");

            string expected = File.ReadAllText("Data/S_Endereco.header.json");
            string actual = asset.ToJson();
            Assert.Equal(expected, actual);
        }
    }
}