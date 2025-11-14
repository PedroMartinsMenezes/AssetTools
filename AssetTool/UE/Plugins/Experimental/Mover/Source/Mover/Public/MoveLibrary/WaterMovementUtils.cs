namespace AssetTool
{
    [JsonAsset("WaterMovementUtils")]
    public class UWaterMovementUtils : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}