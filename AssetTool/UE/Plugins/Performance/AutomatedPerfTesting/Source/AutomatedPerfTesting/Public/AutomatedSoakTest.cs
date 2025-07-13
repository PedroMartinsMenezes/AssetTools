namespace AssetTool
{
    [JsonAsset("AutomatedSoakTest")]
    public class UAutomatedSoakTest : UAutomatedPerfTestControllerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}