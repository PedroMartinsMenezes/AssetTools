namespace AssetTool
{
    [JsonAsset("EnhancedInputLibrary")]
    public class UEnhancedInputLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}