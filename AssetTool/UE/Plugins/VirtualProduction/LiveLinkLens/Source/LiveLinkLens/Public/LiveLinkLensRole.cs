namespace AssetTool
{
    [JsonAsset("LiveLinkLensRole")]
    public class ULiveLinkLensRole : ULiveLinkCameraRole
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}