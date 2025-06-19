namespace AssetTool
{
    [JsonAsset("EnhancedInputLibrary")]
    public class UEnhancedInputLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}