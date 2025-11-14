namespace AssetTool
{
    [JsonAsset("AutomatedSoakTest")]
    public class UAutomatedSoakTest : UAutomatedPerfTestControllerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}