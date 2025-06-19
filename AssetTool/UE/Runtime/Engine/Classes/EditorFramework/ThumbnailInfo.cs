namespace AssetTool
{
    [JsonAsset("ThumbnailInfo")]
    public class UThumbnailInfo : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}