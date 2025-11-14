namespace AssetTool
{
    [JsonAsset("WidgetToolsContext")]
    public class UWidgetToolsContext : UModeManagerInteractiveToolsContext
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}