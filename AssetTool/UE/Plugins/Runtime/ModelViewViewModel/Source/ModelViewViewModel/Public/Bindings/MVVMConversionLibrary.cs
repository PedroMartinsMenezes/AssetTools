namespace AssetTool
{
    [JsonAsset("MVVMConversionLibrary")]
    public class UMVVMConversionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}