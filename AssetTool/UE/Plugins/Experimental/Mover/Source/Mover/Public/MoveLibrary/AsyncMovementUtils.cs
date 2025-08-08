namespace AssetTool
{
    [JsonAsset("AsyncMovementUtils")]
    public class UAsyncMovementUtils : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}