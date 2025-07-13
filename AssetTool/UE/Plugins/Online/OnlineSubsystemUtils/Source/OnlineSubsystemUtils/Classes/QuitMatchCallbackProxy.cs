namespace AssetTool
{
    [JsonAsset("QuitMatchCallbackProxy")]
    public class UQuitMatchCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}