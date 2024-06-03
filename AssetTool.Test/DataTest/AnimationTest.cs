namespace AssetTool.Test
{
    public class AnimationTest : TestBase
    {
        public AnimationTest() => GlobalNames.Clear();

        [Fact] public void BS_MM_WalkRun() => Assert.True(StructWriter.RebuildAsset("BS_MM_WalkRun"));
    }
}