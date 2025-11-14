namespace AssetTool
{
    [JsonAsset("SkeletonThumbnailRenderer")]
    public class USkeletonThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}