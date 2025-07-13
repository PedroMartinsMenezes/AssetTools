namespace AssetTool
{
    [JsonAsset("OpenXRBlueprintFunctionLibrary")]
    public class UOpenXRBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}