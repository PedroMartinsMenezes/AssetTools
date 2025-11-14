namespace AssetTool
{
    [JsonAsset("AutomatedPerfTestControllerBase")]
    public class UAutomatedPerfTestControllerBase : UGauntletTestController
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}