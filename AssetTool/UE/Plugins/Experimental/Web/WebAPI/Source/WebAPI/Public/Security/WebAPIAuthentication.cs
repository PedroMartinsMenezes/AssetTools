namespace AssetTool
{
    [JsonAsset("WebAPIAuthenticationSettings")]
    public class UWebAPIAuthenticationSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WebAPIOAuthSettings")]
    public class UWebAPIOAuthSettings : UWebAPIAuthenticationSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}