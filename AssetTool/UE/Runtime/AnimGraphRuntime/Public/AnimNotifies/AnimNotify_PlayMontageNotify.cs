namespace AssetTool
{
    [JsonAsset("AnimNotify_PlayMontageNotify")]
    public class UAnimNotify_PlayMontageNotify : UAnimNotify
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimNotify_PlayMontageNotifyWindow")]
    public class UAnimNotify_PlayMontageNotifyWindow : UAnimNotifyState
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}