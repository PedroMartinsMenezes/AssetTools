namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeTransformParameter")]
    public class UCustomizableObjectNodeTransformParameter : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}