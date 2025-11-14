namespace AssetTool
{
    [JsonAsset("PhysicsAssetThumbnailRenderer")]
    public class UPhysicsAssetThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}