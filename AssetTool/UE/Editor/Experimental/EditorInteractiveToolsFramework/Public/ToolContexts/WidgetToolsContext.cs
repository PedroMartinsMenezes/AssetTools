namespace AssetTool
{
    [JsonAsset("WidgetToolsContext")]
    public class UWidgetToolsContext : UModeManagerInteractiveToolsContext
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}