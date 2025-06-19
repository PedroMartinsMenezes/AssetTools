namespace AssetTool
{
    [JsonAsset("EdModeDefault")]
    public class UEdModeDefault : UBaseLegacyWidgetEdMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}