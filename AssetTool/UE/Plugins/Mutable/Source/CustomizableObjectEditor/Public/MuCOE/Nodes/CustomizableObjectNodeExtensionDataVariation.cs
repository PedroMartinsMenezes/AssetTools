namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeExtensionDataVariation")]
    public class UCustomizableObjectNodeExtensionDataVariation : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}