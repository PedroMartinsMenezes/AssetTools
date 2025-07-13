namespace AssetTool
{
    [JsonAsset("LogoutCallbackProxy")]
    public class ULogoutCallbackProxy : UBlueprintAsyncActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}