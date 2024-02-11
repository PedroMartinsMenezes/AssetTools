namespace AssetTool.Test
{
    public class S_Endereco_Test
    {
        [Fact]
        public void Check_S_Endereco()
        {
            StructWriter.RebuildAsset("S_Endereco");

            byte[] expected = File.ReadAllBytes(StructWriter.PathExpected);
            byte[] actual = File.ReadAllBytes(StructWriter.Path);

            int size = actual.Length;
            Assert.Equal(expected.Take(size), actual.Take(size));
        }
    }
}