namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodePassThroughTexture")]
    public class UCustomizableObjectNodePassThroughTexture : UCustomizableObjectNodeTextureBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}