namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeMaterialVariation")]
    public class UCustomizableObjectNodeMaterialVariation : UCustomizableObjectNodeVariation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}