namespace AssetTool
{
    [JsonAsset("SmartObjectBlueprintFunctionLibrary")]
    public class USmartObjectBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}