namespace AssetTool
{
    [JsonAsset("LiveLinkInstance")]
    public class ULiveLinkInstance : UAnimInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}