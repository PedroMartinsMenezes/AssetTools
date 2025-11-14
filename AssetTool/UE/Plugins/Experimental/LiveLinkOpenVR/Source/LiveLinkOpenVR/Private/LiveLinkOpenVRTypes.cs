namespace AssetTool
{
    [JsonAsset("LiveLinkOpenVRSourceSettings")]
    public class ULiveLinkOpenVRSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}