namespace AssetTool
{
    [JsonAsset("TakesCoreBlueprintLibrary")]
    public class UTakesCoreBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}