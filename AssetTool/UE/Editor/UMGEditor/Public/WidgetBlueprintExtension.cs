namespace AssetTool
{
    [JsonAsset("WidgetBlueprintExtension")]
    public class UWidgetBlueprintExtension : UBlueprintExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}