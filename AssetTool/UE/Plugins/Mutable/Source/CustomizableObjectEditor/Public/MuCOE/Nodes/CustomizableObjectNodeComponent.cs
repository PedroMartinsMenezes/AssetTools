namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeComponent")]
    public class UCustomizableObjectNodeComponent : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}