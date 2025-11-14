namespace AssetTool
{
    [JsonAsset("WidgetBlueprintExtension")]
    public class UWidgetBlueprintExtension : UBlueprintExtension
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}