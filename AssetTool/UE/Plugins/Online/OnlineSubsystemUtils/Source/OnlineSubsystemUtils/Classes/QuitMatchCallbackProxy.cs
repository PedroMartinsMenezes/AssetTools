namespace AssetTool
{
    [JsonAsset("QuitMatchCallbackProxy")]
    public class UQuitMatchCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}