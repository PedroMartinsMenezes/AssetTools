namespace AssetTool
{
    [JsonAsset("AutomationViewSettings")]
    public class UAutomationViewSettings : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}