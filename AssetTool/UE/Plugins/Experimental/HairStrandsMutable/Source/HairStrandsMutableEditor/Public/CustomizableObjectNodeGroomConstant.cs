namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeGroomConstant")]
    public class UCustomizableObjectNodeGroomConstant : UCustomizableObjectNodeExtensionDataConstant
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}