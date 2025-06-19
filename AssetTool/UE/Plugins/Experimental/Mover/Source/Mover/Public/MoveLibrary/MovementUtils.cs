namespace AssetTool
{
    [JsonAsset("MovementUtils")]
    public class UMovementUtils : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}