using AssetTool.Model;
using AssetTool.Service;
using AssetTool.Writer;

namespace AssetTool.Test
{
    public class StructTest
    {
        [Fact]
        public void Compare_Struct()
        {
            StructWriter.SaveStruct();

            byte[] expected = File.ReadAllBytes(StructWriter.PathExpected);
            byte[] actual = File.ReadAllBytes(StructWriter.Path);

            int size = actual.Length;
            Assert.Equal(expected.Take(size), actual.Take(size));
        }

        [Fact]
        public void Read_BPC_XP()
        {
            var obj = "C:\\UE\\RPG\\Content\\RPG\\XP\\BPC_XP.uasset".BinToObject(0, reader =>
            {
                var item = new FPackageFileSummary();
                reader.Read(ref item);
                return item;
            });
            obj.ToJsonFile("Data\\BPC_XP.json");
            Assert.NotNull(obj);
        }
    }
}