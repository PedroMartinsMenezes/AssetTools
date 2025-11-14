namespace AssetTool
{
    [JsonAsset("DestroySessionCallbackProxy")]
    public class UDestroySessionCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}