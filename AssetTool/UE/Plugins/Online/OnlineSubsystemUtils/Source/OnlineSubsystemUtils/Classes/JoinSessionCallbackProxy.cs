namespace AssetTool
{
    [JsonAsset("JoinSessionCallbackProxy")]
    public class UJoinSessionCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}