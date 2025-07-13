namespace AssetTool
{
    [JsonAsset("DestroySessionCallbackProxy")]
    public class UDestroySessionCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}