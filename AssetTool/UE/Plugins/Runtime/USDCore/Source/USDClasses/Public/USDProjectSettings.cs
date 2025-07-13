namespace AssetTool
{
    [JsonAsset("UsdProjectSettings")]
    public class UUsdProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}