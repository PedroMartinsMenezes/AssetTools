namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeTextureTransform")]
    public class UCustomizableObjectNodeTextureTransform : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}