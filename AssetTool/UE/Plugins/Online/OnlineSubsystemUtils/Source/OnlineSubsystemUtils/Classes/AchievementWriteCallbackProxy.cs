namespace AssetTool
{
    [JsonAsset("AchievementWriteCallbackProxy")]
    public class UAchievementWriteCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}