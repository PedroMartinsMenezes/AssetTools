namespace AssetTool
{
    [JsonAsset("AutomatedPlacedStaticCameraPerfTest")]
    public class UAutomatedPlacedStaticCameraPerfTest : UAutomatedStaticCameraPerfTestBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}