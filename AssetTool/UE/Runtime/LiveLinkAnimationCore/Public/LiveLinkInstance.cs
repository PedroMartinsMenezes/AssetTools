namespace AssetTool
{
    [JsonAsset("LiveLinkInstance")]
    public class ULiveLinkInstance : UAnimInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}