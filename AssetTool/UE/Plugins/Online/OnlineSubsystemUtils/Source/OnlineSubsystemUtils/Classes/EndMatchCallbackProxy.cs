namespace AssetTool
{
    [JsonAsset("EndMatchCallbackProxy")]
    public class UEndMatchCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}