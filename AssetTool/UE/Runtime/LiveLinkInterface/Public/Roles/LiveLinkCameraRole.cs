namespace AssetTool
{
    [JsonAsset("LiveLinkCameraRole")]
    public class ULiveLinkCameraRole : ULiveLinkTransformRole
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}