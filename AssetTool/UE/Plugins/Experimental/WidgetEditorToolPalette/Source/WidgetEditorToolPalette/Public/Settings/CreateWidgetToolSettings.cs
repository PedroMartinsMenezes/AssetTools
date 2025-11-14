namespace AssetTool
{
    [JsonAsset("CreateWidgetToolSettings")]
    public class UCreateWidgetToolSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}