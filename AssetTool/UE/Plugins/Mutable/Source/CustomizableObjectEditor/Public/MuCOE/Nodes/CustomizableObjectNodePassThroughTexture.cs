namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodePassThroughTexture")]
    public class UCustomizableObjectNodePassThroughTexture : UCustomizableObjectNodeTextureBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}