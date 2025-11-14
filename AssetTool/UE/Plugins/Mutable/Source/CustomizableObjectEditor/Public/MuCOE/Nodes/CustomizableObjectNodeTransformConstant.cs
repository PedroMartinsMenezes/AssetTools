namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeTransformConstant")]
    public class UCustomizableObjectNodeTransformConstant : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}