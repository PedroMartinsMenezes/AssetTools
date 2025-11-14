namespace AssetTool
{
    [JsonAsset("CustomizableObjectThumbnailRenderer")]
    public class UCustomizableObjectThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}