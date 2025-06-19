namespace AssetTool
{
    [JsonAsset("WidgetBlueprintLibrary")]
    public class UWidgetBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}