namespace AssetTool
{
    [JsonAsset("LiveLinkTransformRole")]
    public class ULiveLinkTransformRole : ULiveLinkBasicRole
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}