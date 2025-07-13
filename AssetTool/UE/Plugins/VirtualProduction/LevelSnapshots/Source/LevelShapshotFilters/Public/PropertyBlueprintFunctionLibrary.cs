namespace AssetTool
{
    [JsonAsset("PropertyBlueprintFunctionLibrary")]
    public class UPropertyBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}