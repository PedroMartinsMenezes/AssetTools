namespace AssetTool
{
    [JsonAsset("LogoutCallbackProxy")]
    public class ULogoutCallbackProxy : UBlueprintAsyncActionBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}