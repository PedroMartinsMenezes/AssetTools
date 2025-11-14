namespace AssetTool
{
    [JsonAsset("AnimNotify_GameplayCue")]
    public class UAnimNotify_GameplayCue : UAnimNotify
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimNotify_GameplayCueState")]
    public class UAnimNotify_GameplayCueState : UAnimNotifyState
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}