namespace AssetTool
{
    [JsonAsset("AutomatedPlacedStaticCameraPerfTest")]
    public class UAutomatedPlacedStaticCameraPerfTest : UAutomatedStaticCameraPerfTestBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}