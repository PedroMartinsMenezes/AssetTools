namespace AssetTool.Test
{
    [Collection("Sequential")]
    public class QuinnTests : TestBase
    {
        public QuinnTests() => GlobalNames.Clear();

        [Fact] public void BS_MF_Unarmed_WalkRun() => Assert.True(StructWriter.RebuildAsset("Quinn/BS_MF_Unarmed_WalkRun"));
        [Fact] public void MF_Run_Fwd() => Assert.True(StructWriter.RebuildAsset("Quinn/MF_Run_Fwd"));
        [Fact] public void MF_Walk_Fwd() => Assert.True(StructWriter.RebuildAsset("Quinn/MF_Walk_Fwd"));
        [Fact] public void MF_Idle() => Assert.True(StructWriter.RebuildAsset("Quinn/MF_Idle"));

        ///[Fact] public void ABP_Quinn() => Assert.True(StructWriter.RebuildAsset("Quinn/ABP_Quinn"));
    }
}