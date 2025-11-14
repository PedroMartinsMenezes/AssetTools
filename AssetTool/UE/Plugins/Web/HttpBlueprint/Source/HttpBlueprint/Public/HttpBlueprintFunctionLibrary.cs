namespace AssetTool
{
    [JsonAsset("HttpBlueprintFunctionLibrary")]
    public class UHttpBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}