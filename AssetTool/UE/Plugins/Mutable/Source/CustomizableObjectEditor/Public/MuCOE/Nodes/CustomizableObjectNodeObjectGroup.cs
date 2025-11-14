namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeObjectGroup")]
    public class UCustomizableObjectNodeObjectGroup : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}