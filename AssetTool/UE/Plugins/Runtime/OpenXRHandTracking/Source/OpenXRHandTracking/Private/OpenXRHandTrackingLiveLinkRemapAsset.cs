namespace AssetTool
{
    [JsonAsset("OpenXRHandTrackingLiveLinkRemapAsset")]
    public class UOpenXRHandTrackingLiveLinkRemapAsset : ULiveLinkRetargetAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}