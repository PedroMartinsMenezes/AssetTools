namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeLayoutBlocks")]
    public class UCustomizableObjectNodeLayoutBlocks : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}