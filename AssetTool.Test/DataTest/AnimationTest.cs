namespace AssetTool.Test
{
    [Collection("Sequential")]
    public class AnimationTest : TestBase
    {
        public AnimationTest() => GlobalNames.Clear();

        [Fact] public void BS_MM_WalkRun() => Assert.True(StructWriter.RebuildAsset("BS_MM_WalkRun"));
        [Fact] public void MM_T_Pose() => Assert.True(StructWriter.RebuildAsset("MM_T_Pose"));
        [Fact] public void MM_Jump() => Assert.True(StructWriter.RebuildAsset("MM_Jump"));
        [Fact] public void MM_Run_Fwd() => Assert.True(StructWriter.RebuildAsset("MM_Run_Fwd"));
        [Fact] public void MM_Land() => Assert.True(StructWriter.RebuildAsset("MM_Land"));

        //[Fact] public void ABP_Manny() => Assert.True(StructWriter.RebuildAssetInMemory("ABP_Manny"));

        //[Fact] public void ABP_Quinn() => Assert.True(StructWriter.RebuildAssetInMemory("ABP_Quinn"));
    }
}