namespace AssetTool
{
    [JsonAsset("WidgetPreviewFactory")]
    public class UWidgetPreviewFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}