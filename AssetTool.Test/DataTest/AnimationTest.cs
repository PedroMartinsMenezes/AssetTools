namespace AssetTool.Test
{
    public class AnimationTest : TestBase
    {
        public AnimationTest() => GlobalNames.Clear();

        [Fact] public void BS_MM_WalkRun() => Assert.True(StructWriter.RebuildAssetInMemory("BS_MM_WalkRun"));

        [Fact] public void MM_T_Pose() => Assert.True(StructWriter.RebuildAssetInMemory("MM_T_Pose"));

        //[Fact] public void ABP_Manny() => Assert.True(StructWriter.RebuildAssetInMemory("ABP_Manny"));

        //[Fact] public void ABP_Quinn() => Assert.True(StructWriter.RebuildAssetInMemory("ABP_Quinn"));
    }
}