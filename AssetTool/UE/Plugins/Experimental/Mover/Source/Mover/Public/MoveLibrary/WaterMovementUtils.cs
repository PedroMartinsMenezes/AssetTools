namespace AssetTool
{
    [JsonAsset("WaterMovementUtils")]
    public class UWaterMovementUtils : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}