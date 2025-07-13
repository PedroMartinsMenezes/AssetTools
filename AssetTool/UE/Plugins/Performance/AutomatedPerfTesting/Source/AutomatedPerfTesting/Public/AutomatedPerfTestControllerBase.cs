namespace AssetTool
{
    [JsonAsset("AutomatedPerfTestControllerBase")]
    public class UAutomatedPerfTestControllerBase : UGauntletTestController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}