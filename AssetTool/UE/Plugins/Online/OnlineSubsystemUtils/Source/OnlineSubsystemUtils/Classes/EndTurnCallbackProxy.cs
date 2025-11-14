namespace AssetTool
{
    [JsonAsset("EndTurnCallbackProxy")]
    public class UEndTurnCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}