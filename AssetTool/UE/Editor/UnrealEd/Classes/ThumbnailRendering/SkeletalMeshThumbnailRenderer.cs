namespace AssetTool
{
    [JsonAsset("SkeletalMeshThumbnailRenderer")]
    public class USkeletalMeshThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}