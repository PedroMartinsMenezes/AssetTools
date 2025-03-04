namespace AssetTool
{
    [JsonAsset("LiveLinkCurveRemapSettings")]
    public class ULiveLinkCurveRemapSettings : ULiveLinkSourceSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}