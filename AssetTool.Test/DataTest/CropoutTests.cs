namespace AssetTool.Test
{
    [Collection("Sequential")]
    public class CropoutTests : TestBase
    {
        public CropoutTests() => GlobalNames.Clear();

        [Fact] public void ST_Job() => Assert.True(StructWriter.RebuildAsset("CropoutSampleProject/Villagers/ST_Job"));
    }
}