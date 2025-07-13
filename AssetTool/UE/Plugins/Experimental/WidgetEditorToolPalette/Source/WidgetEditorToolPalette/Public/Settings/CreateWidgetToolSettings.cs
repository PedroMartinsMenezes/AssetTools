namespace AssetTool
{
    [JsonAsset("CreateWidgetToolSettings")]
    public class UCreateWidgetToolSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}