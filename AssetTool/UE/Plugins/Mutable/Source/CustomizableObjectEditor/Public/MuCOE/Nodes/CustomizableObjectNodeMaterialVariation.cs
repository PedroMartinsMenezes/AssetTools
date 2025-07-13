namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeMaterialVariation")]
    public class UCustomizableObjectNodeMaterialVariation : UCustomizableObjectNodeVariation
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}