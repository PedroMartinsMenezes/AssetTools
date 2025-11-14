namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodePassThroughTextureVariation")]
    public class UCustomizableObjectNodePassThroughTextureVariation : UCustomizableObjectNodeTextureVariation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}