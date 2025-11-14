namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeExposePin")]
    public class UCustomizableObjectNodeExposePin : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}