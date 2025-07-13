namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeDNAConstant")]
    public class UCustomizableObjectNodeDNAConstant : UCustomizableObjectNodeExtensionDataConstant
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}