namespace AssetTool
{
    [JsonAsset("LiveLinkComponentSettings")]
    public class ULiveLinkComponentSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}