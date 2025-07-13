namespace AssetTool
{
    [JsonAsset("EndMatchCallbackProxy")]
    public class UEndMatchCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}