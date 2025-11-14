namespace AssetTool
{
    [JsonAsset("JoinSessionCallbackProxy")]
    public class UJoinSessionCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}