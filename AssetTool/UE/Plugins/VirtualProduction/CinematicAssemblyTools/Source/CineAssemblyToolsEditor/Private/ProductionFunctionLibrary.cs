namespace AssetTool
{
    [JsonAsset("ProductionFunctionLibrary")]
    public class UProductionFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}