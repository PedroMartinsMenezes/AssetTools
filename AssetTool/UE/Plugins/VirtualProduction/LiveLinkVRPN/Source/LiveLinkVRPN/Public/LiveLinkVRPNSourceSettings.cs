namespace AssetTool
{
    [JsonAsset("LiveLinkVRPNSourceSettings")]
    public class ULiveLinkVRPNSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}