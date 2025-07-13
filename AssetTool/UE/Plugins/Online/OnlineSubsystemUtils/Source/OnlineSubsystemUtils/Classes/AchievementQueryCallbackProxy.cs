namespace AssetTool
{
    [JsonAsset("AchievementQueryCallbackProxy")]
    public class UAchievementQueryCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}