namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeMaterialBase")]
    public class UCustomizableObjectNodeMaterialBase : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}