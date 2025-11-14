namespace AssetTool
{
    [JsonAsset("MovementUtils")]
    public class UMovementUtils : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}