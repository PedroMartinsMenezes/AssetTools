namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodePassThroughTextureVariation")]
    public class UCustomizableObjectNodePassThroughTextureVariation : UCustomizableObjectNodeTextureVariation
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}