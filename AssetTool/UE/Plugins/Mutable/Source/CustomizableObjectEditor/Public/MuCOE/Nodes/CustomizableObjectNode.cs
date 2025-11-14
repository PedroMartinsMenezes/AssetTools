namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodePinData")]
    public class UCustomizableObjectNodePinData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNode")]
    public class UCustomizableObjectNode : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}