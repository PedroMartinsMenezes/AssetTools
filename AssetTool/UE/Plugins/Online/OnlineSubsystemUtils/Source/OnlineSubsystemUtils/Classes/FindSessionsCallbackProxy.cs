namespace AssetTool
{
    [JsonAsset("FindSessionsCallbackProxy")]
    public class UFindSessionsCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}