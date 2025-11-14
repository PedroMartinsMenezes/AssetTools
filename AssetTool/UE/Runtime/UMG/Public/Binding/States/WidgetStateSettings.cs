namespace AssetTool
{
    [JsonAsset("WidgetStateSettings")]
    public class UWidgetStateSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}