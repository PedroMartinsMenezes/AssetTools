namespace AssetTool
{
    [JsonAsset("LiveLinkUserSettings")]
    public class ULiveLinkUserSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LiveLinkSettings")]
    public class ULiveLinkSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}