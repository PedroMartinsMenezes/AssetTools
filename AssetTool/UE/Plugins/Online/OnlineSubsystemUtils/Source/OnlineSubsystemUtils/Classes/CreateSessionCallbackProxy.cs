namespace AssetTool
{
    [JsonAsset("CreateSessionCallbackProxy")]
    public class UCreateSessionCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}