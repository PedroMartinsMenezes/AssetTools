namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeModifierExtendMeshSection")]
    public class UCustomizableObjectNodeModifierExtendMeshSection : UCustomizableObjectNodeModifierWithMaterial
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}