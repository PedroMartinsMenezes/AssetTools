namespace AssetTool
{
    [JsonAsset("BasedMovementUtils")]
    public class UBasedMovementUtils : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}