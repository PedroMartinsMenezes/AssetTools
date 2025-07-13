namespace AssetTool
{
    [JsonAsset("OpenXRHandTrackingLiveLinkRemapAsset")]
    public class UOpenXRHandTrackingLiveLinkRemapAsset : ULiveLinkRetargetAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}