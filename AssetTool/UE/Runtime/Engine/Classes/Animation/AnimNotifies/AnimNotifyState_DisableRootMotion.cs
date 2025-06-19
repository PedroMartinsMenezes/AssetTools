namespace AssetTool
{
    [JsonAsset("AnimNotifyState_DisableRootMotion")]
    public class UAnimNotifyState_DisableRootMotion : UAnimNotifyState
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}