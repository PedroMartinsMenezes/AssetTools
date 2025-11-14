namespace AssetTool
{
    [JsonAsset("EnhancedInputLibrary")]
    public class UEnhancedInputLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}