namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeExposePin")]
    public class UCustomizableObjectNodeExposePin : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}