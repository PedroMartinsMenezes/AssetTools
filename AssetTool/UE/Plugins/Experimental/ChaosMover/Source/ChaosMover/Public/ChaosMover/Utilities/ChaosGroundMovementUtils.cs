namespace AssetTool
{
    [JsonAsset("ChaosGroundMovementUtils")]
    public class UChaosGroundMovementUtils : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}