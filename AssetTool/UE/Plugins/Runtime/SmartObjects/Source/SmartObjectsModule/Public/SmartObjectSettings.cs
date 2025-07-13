namespace AssetTool
{
    [JsonAsset("SmartObjectSettings")]
    public class USmartObjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}