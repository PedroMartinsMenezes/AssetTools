namespace AssetTool
{
    [JsonAsset("WebAPILiquidJSSettings")]
    public class UWebAPILiquidJSSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}