namespace AssetTool
{
    [JsonAsset("SkeletonThumbnailRenderer")]
    public class USkeletonThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}