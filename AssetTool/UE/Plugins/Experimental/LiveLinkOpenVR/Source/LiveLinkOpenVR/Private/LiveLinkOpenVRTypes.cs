namespace AssetTool
{
    [JsonAsset("LiveLinkOpenVRSourceSettings")]
    public class ULiveLinkOpenVRSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}