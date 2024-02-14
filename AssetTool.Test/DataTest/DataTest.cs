namespace AssetTool.Test
{
    public class DataTest
    {
        [Fact]
        public void Check_S_Endereco()
        {
            GlobalNames.Clear();
            bool success = StructWriter.RebuildAsset("S_Endereco");
            Assert.True(success);
        }

        [Fact]
        public void Check_BP_ThirdPersonCharacter()
        {
            GlobalNames.Clear();
            bool success = StructWriter.RebuildAsset("BP_ThirdPersonCharacter");
            Assert.True(success);
        }
    }
}