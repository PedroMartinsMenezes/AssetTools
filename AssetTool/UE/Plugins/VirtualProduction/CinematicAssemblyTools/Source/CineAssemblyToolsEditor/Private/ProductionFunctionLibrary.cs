namespace AssetTool
{
    [JsonAsset("ProductionFunctionLibrary")]
    public class UProductionFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}