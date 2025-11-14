namespace AssetTool
{
    [JsonAsset("BasedMovementUtils")]
    public class UBasedMovementUtils : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}