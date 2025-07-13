namespace AssetTool
{
    [JsonAsset("OnlineBlueprintCallProxyBase")]
    public class UOnlineBlueprintCallProxyBase : UBlueprintAsyncActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}