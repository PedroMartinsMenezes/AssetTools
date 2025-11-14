namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeObject")]
    public class UCustomizableObjectNodeObject : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}