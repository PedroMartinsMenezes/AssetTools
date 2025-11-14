namespace AssetTool
{
    [JsonAsset("WebAPIDeveloperSettings")]
    public class UWebAPIDeveloperSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}