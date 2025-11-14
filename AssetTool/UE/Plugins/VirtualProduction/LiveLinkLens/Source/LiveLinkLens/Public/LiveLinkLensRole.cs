namespace AssetTool
{
    [JsonAsset("LiveLinkLensRole")]
    public class ULiveLinkLensRole : ULiveLinkCameraRole
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}