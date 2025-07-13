namespace AssetTool
{
    [JsonAsset("HttpBlueprintFunctionLibrary")]
    public class UHttpBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}