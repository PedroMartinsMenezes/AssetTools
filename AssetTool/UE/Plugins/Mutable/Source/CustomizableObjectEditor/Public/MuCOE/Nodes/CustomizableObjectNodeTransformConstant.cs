namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeTransformConstant")]
    public class UCustomizableObjectNodeTransformConstant : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}