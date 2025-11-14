namespace AssetTool
{
    [JsonAsset("SmartObjectBlueprintFunctionLibrary")]
    public class USmartObjectBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}