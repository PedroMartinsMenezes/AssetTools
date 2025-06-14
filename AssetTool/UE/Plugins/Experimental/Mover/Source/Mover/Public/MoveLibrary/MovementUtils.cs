namespace AssetTool
{
    [JsonAsset("MovementUtils")]
    public class UMovementUtils : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}