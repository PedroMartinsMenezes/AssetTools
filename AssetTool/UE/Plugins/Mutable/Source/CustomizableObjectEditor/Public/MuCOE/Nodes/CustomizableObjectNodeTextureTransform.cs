namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeTextureTransform")]
    public class UCustomizableObjectNodeTextureTransform : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}