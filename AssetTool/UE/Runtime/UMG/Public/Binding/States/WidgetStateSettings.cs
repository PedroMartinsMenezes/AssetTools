namespace AssetTool
{
    [JsonAsset("WidgetStateSettings")]
    public class UWidgetStateSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}