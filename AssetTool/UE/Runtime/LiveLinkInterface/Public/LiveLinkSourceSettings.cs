namespace AssetTool
{
    [JsonAsset("LiveLinkSourceSettings")]
    public class ULiveLinkSourceSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}