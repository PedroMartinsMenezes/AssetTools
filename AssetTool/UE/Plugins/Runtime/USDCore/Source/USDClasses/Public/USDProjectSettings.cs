namespace AssetTool
{
    [JsonAsset("UsdProjectSettings")]
    public class UUsdProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}