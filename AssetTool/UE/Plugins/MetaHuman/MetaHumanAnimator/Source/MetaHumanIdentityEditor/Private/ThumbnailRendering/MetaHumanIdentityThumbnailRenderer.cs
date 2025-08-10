namespace AssetTool
{
    [JsonAsset("MetaHumanIdentityThumbnailRenderer")]
    public class UMetaHumanIdentityThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}