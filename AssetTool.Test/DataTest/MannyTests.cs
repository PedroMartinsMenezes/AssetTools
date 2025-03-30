using NUnit.Framework;

namespace AssetTool.Test
{
    public class MannyTests : TestBase
    {
        //public MannyTests() => GlobalNames.Clear();

        [Test] public void BS_MM_WalkRun() => Assert.That(StructWriter.RebuildAsset("Manny/BS_MM_WalkRun"));
        [Test] public void MM_T_Pose() => Assert.That(StructWriter.RebuildAsset("Manny/MM_T_Pose"));
        [Test] public void MM_Jump() => Assert.That(StructWriter.RebuildAsset("Manny/MM_Jump"));
        [Test] public void MM_Run_Fwd() => Assert.That(StructWriter.RebuildAsset("Manny/MM_Run_Fwd"));
        [Test] public void MM_Land() => Assert.That(StructWriter.RebuildAsset("Manny/MM_Land"));
        [Test] public void MM_Walk_Fwd() => Assert.That(StructWriter.RebuildAsset("Manny/MM_Walk_Fwd"));
        [Test] public void MM_Walk_InPlace() => Assert.That(StructWriter.RebuildAsset("Manny/MM_Walk_InPlace"));
        [Test] public void MM_Fall_Loop() => Assert.That(StructWriter.RebuildAsset("Manny/MM_Fall_Loop"));
        [Test] public void MM_Idle() => Assert.That(StructWriter.RebuildAsset("Manny/MM_Idle"));
        [Test] public void ABP_Manny() => Assert.That(StructWriter.RebuildAsset("Manny/ABP_Manny"));
    }
}