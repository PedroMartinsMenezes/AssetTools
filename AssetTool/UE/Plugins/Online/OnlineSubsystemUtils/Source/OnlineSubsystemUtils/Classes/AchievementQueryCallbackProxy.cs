namespace AssetTool
{
    [JsonAsset("AchievementQueryCallbackProxy")]
    public class UAchievementQueryCallbackProxy : UOnlineBlueprintCallProxyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}