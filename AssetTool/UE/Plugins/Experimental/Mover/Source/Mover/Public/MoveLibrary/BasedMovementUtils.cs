namespace AssetTool
{
    [JsonAsset("BasedMovementUtils")]
    public class UBasedMovementUtils : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}