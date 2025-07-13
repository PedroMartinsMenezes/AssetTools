namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeCurve")]
    public class UCustomizableObjectNodeCurve : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}