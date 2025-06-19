namespace AssetTool
{
    [JsonAsset("PhysicsAssetThumbnailRenderer")]
    public class UPhysicsAssetThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}