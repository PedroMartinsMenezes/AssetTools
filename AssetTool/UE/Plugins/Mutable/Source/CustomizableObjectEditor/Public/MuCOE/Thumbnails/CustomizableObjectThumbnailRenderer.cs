namespace AssetTool
{
    [JsonAsset("CustomizableObjectThumbnailRenderer")]
    public class UCustomizableObjectThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}