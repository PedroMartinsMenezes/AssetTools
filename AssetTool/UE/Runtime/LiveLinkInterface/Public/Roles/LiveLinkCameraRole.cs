namespace AssetTool
{
    [JsonAsset("LiveLinkCameraRole")]
    public class ULiveLinkCameraRole : ULiveLinkTransformRole
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}