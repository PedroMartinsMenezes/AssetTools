namespace AssetTool
{
    [JsonAsset("LiveLinkSourceSettings")]
    public class ULiveLinkSourceSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}