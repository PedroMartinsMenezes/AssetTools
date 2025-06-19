namespace AssetTool
{
    [JsonAsset("AutomationTestSettings")]
    public class UAutomationTestSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}