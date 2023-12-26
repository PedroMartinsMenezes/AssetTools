using AssetTool.Writer;

namespace AssetTool.Test
{
    public class StructTest
    {
        [Fact]
        public void SaveStruct()
        {
            StructWriter.SaveStruct();

            byte[] expected = File.ReadAllBytes(StructWriter.PathExpected);
            byte[] actual = File.ReadAllBytes(StructWriter.Path);

            int size = actual.Length;
            Assert.Equal(expected.Take(size), actual.Take(size));
        }
    }
}