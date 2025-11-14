namespace AssetTool
{
    [JsonAsset("LiveLinkVRPNSourceSettings")]
    public class ULiveLinkVRPNSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}