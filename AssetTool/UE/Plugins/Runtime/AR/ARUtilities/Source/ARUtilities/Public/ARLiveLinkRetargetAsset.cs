namespace AssetTool
{
    [JsonAsset("ARLiveLinkRetargetAsset")]
    public class UARLiveLinkRetargetAsset : ULiveLinkRetargetAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}