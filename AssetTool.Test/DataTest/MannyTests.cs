namespace AssetTool.Test
{
    [Collection("Sequential")]
    public class MannyTests : TestBase
    {
        public MannyTests() => GlobalNames.Clear();

        [Fact] public void BS_MM_WalkRun() => Assert.True(StructWriter.RebuildAsset("Manny/BS_MM_WalkRun"));
        [Fact] public void MM_T_Pose() => Assert.True(StructWriter.RebuildAsset("Manny/MM_T_Pose"));
        [Fact] public void MM_Jump() => Assert.True(StructWriter.RebuildAsset("Manny/MM_Jump"));
        [Fact] public void MM_Run_Fwd() => Assert.True(StructWriter.RebuildAsset("Manny/MM_Run_Fwd"));
        [Fact] public void MM_Land() => Assert.True(StructWriter.RebuildAsset("Manny/MM_Land"));
        [Fact] public void MM_Walk_Fwd() => Assert.True(StructWriter.RebuildAsset("Manny/MM_Walk_Fwd"));
        [Fact] public void MM_Walk_InPlace() => Assert.True(StructWriter.RebuildAsset("Manny/MM_Walk_InPlace"));
        [Fact] public void MM_Fall_Loop() => Assert.True(StructWriter.RebuildAsset("Manny/MM_Fall_Loop"));
        [Fact] public void MM_Idle() => Assert.True(StructWriter.RebuildAsset("Manny/MM_Idle"));

        [Fact] public void ABP_Manny() => Assert.True(StructWriter.RebuildAsset("Manny/ABP_Manny"));
    }
}