namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeCurve")]
    public class UCustomizableObjectNodeCurve : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}