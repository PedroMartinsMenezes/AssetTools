namespace AssetTool.Test
{
    public class DataTest : TestBase
    {
        [Fact]
        public void S_Endereco()
        {
            GlobalNames.Clear();
            bool success = StructWriter.RebuildAsset("S_Endereco");
            Assert.True(success);
        }

        [Fact]
        public void BP_ThirdPersonCharacter()
        {
            GlobalNames.Clear();
            bool success = StructWriter.RebuildAsset("BP_ThirdPersonCharacter");
            Assert.True(success);
        }

        [Fact]
        public void FogBrightnessLUT()
        {
            GlobalNames.Clear();
            bool success = StructWriter.RebuildAsset("FogBrightnessLUT");
            Assert.True(success);
        }

        //[Fact]
        public void SunlightColorLUT()
        {
            GlobalNames.Clear();
            bool success = StructWriter.RebuildAsset("SunlightColorLUT");
            Assert.True(success);
        }
    }
}