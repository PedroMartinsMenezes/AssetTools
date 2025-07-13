namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeLayoutBlocks")]
    public class UCustomizableObjectNodeLayoutBlocks : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}