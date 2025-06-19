namespace AssetTool
{
    [JsonAsset("LiveLinkCurveRemapSettings")]
    public class ULiveLinkCurveRemapSettings : ULiveLinkSourceSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}