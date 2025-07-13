namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeTextureBase")]
    public class UCustomizableObjectNodeTextureBase : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeTexture")]
    public class UCustomizableObjectNodeTexture : UCustomizableObjectNodeTextureBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}