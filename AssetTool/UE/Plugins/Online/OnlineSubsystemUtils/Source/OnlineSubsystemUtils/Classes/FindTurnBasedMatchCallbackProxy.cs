namespace AssetTool
{
    [JsonAsset("FindTurnBasedMatchCallbackProxy")]
    public class UFindTurnBasedMatchCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}