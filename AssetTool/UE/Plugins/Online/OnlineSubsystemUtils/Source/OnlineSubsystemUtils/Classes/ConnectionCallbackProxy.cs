namespace AssetTool
{
    [JsonAsset("ConnectionCallbackProxy")]
    public class UConnectionCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}