namespace AssetTool
{
    [JsonAsset("GroundMovementUtils")]
    public class UGroundMovementUtils : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}