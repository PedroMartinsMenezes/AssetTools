namespace AssetTool
{
    [JsonAsset("AutomationTestSettings")]
    public class UAutomationTestSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}