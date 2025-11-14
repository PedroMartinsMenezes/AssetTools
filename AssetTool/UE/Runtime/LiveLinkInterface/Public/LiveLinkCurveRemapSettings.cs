namespace AssetTool
{
    [JsonAsset("LiveLinkCurveRemapSettings")]
    public class ULiveLinkCurveRemapSettings : ULiveLinkSourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}