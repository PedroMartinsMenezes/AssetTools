namespace AssetTool.Test
{
    [Collection("Sequential")]
    public class CropoutTests : TestBase
    {
        public CropoutTests() => GlobalNames.Clear();

        [Fact] public void DT_Jobs() => Assert.True(StructWriter.RebuildAsset("CropoutSampleProject/Villagers/DT_Jobs"));
        [Fact] public void ST_Job() => Assert.True(StructWriter.RebuildAsset("CropoutSampleProject/Villagers/ST_Job"));
        [Fact] public void BPI_Villager() => Assert.True(StructWriter.RebuildAsset("CropoutSampleProject/Villagers/BPI_Villager"));
        [Fact] public void BP_Villager() => Assert.True(StructWriter.RebuildAsset("CropoutSampleProject/Villagers/BP_Villager"));
    }
}