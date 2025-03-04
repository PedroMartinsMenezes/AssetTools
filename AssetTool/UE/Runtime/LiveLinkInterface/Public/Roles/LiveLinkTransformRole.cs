namespace AssetTool
{
    [JsonAsset("LiveLinkTransformRole")]
    public class ULiveLinkTransformRole : ULiveLinkBasicRole
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}