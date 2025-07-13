namespace AssetTool
{
    [JsonAsset("UIFrameworkLocalSettings")]
    public class UUIFrameworkLocalSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}