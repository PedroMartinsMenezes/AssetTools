namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodePinData")]
    public class UCustomizableObjectNodePinData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNode")]
    public class UCustomizableObjectNode : UEdGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}