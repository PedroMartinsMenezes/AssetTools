namespace AssetTool
{
    [JsonAsset("CustomizableObjectInstanceThumbnailRenderer")]
    public class UCustomizableObjectInstanceThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}