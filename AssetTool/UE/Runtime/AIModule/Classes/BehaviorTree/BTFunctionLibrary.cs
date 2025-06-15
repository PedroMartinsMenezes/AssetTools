namespace AssetTool
{
    [JsonAsset("BTFunctionLibrary")]
    public class UBTFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}