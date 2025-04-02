using NUnit.Framework;

namespace AssetTool.Test
{
    public class QuinnTests : TestBase
    {
        //public QuinnTests() => GlobalNames.Clear();

        [Test] public void BS_MF_Unarmed_WalkRun() => Assert.That(StructWriter.RebuildAsset("Quinn/BS_MF_Unarmed_WalkRun"));
        [Test] public void MF_Run_Fwd() => Assert.That(StructWriter.RebuildAsset("Quinn/MF_Run_Fwd"));
        [Test] public void MF_Walk_Fwd() => Assert.That(StructWriter.RebuildAsset("Quinn/MF_Walk_Fwd"));
        [Test] public void MF_Idle() => Assert.That(StructWriter.RebuildAsset("Quinn/MF_Idle"));
        [Test] public void ABP_Quinn() => Assert.That(StructWriter.RebuildAsset("Quinn/ABP_Quinn"));
    }
}