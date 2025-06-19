namespace AssetTool
{
    [JsonAsset("LiveLinkCameraRole")]
    public class ULiveLinkCameraRole : ULiveLinkTransformRole
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}