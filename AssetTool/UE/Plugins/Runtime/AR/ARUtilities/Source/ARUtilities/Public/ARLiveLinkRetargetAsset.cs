namespace AssetTool
{
    [JsonAsset("ARLiveLinkRetargetAsset")]
    public class UARLiveLinkRetargetAsset : ULiveLinkRetargetAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}