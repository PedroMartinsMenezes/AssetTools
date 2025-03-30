using NUnit.Framework;

namespace AssetTool.Test
{

    public class CropoutTests : TestBase
    {
        //public CropoutTests() => GlobalNames.Clear();

        [Test] public void DT_Jobs() => Assert.That(StructWriter.RebuildAsset("CropoutSampleProject/Villagers/DT_Jobs"));
        [Test] public void ST_Job() => Assert.That(StructWriter.RebuildAsset("CropoutSampleProject/Villagers/ST_Job"));
        [Test] public void BPI_Villager() => Assert.That(StructWriter.RebuildAsset("CropoutSampleProject/Villagers/BPI_Villager"));
        [Test] public void BP_Villager() => Assert.That(StructWriter.RebuildAsset("CropoutSampleProject/Villagers/BP_Villager"));
    }
}