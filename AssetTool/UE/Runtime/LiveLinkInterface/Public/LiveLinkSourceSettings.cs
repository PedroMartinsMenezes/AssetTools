namespace AssetTool
{
    [JsonAsset("LiveLinkSourceSettings")]
    public class ULiveLinkSourceSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}