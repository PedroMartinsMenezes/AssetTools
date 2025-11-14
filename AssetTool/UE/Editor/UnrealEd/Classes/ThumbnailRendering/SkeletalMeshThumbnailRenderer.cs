namespace AssetTool
{
    [JsonAsset("SkeletalMeshThumbnailRenderer")]
    public class USkeletalMeshThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}