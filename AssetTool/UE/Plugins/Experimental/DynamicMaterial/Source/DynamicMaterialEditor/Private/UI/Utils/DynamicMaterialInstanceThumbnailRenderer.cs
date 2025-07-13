namespace AssetTool
{
    [JsonAsset("DynamicMaterialInstanceThumbnailRenderer")]
    public class UDynamicMaterialInstanceThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}