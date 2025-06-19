namespace AssetTool
{
    [JsonAsset("BlueprintAsyncActionBase")]
    public class UBlueprintAsyncActionBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}