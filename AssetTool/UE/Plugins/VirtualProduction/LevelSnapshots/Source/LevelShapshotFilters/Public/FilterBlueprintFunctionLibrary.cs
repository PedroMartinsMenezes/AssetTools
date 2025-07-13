namespace AssetTool
{
    [JsonAsset("FilterBlueprintFunctionLibrary")]
    public class UFilterBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}