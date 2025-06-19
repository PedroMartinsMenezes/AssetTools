namespace AssetTool
{
    [JsonAsset("IKRigThumbnailRenderer")]
    public class UIKRigThumbnailRenderer : USkeletalMeshThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}