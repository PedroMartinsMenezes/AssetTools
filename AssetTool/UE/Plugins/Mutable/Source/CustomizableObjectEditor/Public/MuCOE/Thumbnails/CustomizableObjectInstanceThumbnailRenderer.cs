namespace AssetTool
{
    [JsonAsset("CustomizableObjectInstanceThumbnailRenderer")]
    public class UCustomizableObjectInstanceThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}