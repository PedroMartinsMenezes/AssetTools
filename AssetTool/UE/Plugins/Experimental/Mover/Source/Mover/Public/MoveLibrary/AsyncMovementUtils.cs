namespace AssetTool
{
    [JsonAsset("AsyncMovementUtils")]
    public class UAsyncMovementUtils : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}