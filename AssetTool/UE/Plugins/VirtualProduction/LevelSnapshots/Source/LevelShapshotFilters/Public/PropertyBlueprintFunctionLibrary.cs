namespace AssetTool
{
    [JsonAsset("PropertyBlueprintFunctionLibrary")]
    public class UPropertyBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}