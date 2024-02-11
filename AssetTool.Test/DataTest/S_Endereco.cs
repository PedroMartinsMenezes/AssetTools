namespace AssetTool.Test
{
    public class S_Endereco_Test
    {
        [Fact]
        public void Check_S_Endereco()
        {
            bool success = StructWriter.RebuildAsset("S_Endereco");
            Assert.True(success);
        }
    }
}