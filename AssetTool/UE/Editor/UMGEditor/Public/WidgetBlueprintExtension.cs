namespace AssetTool
{
    [JsonAsset("WidgetBlueprintExtension")]
    public class UWidgetBlueprintExtension : UBlueprintExtension
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}