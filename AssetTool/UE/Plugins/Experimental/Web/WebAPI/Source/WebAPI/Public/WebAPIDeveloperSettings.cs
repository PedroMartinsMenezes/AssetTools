namespace AssetTool
{
    [JsonAsset("WebAPIDeveloperSettings")]
    public class UWebAPIDeveloperSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}