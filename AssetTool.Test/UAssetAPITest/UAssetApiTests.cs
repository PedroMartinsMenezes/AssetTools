using NUnit.Framework;

namespace AssetTool.Test.UAssetAPITest
{
    public class UAssetApiTests : TestBase
    {
        [Test] public void PB_DT_RandomizerRoomCheck() => Assert.That(StructWriter.RebuildAsset("UAssetAPI/TestManyAssets/Bloodstained/PB_DT_RandomizerRoomCheck"));
    }
}
