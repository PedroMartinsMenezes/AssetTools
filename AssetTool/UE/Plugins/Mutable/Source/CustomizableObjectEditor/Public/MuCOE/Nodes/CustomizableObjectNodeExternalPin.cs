namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeExternalPin")]
    public class UCustomizableObjectNodeExternalPin : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}