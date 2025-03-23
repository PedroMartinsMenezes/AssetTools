namespace AssetTool
{
    [JsonAsset("WidgetStateSettings")]
    public class UWidgetStateSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}