namespace AssetTool
{
    [JsonAsset("AutomationTestSettings")]
    public class UAutomationTestSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}