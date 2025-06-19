namespace AssetTool
{
    [JsonAsset("LiveLinkController")]
    public class ULiveLinkController : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}