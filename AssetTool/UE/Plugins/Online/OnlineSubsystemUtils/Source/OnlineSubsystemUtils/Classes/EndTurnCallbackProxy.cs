namespace AssetTool
{
    [JsonAsset("EndTurnCallbackProxy")]
    public class UEndTurnCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}