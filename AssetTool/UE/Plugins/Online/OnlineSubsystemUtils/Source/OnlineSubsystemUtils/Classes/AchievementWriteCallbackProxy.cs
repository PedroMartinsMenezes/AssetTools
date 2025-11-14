namespace AssetTool
{
    [JsonAsset("AchievementWriteCallbackProxy")]
    public class UAchievementWriteCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}