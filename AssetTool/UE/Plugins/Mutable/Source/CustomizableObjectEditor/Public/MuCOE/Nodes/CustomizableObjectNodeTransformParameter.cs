namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeTransformParameter")]
    public class UCustomizableObjectNodeTransformParameter : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}