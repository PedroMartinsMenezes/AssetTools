namespace AssetTool
{
    [JsonAsset("ConnectionCallbackProxy")]
    public class UConnectionCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}