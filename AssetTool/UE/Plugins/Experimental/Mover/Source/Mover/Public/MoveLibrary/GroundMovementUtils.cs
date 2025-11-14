namespace AssetTool
{
    [JsonAsset("GroundMovementUtils")]
    public class UGroundMovementUtils : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}