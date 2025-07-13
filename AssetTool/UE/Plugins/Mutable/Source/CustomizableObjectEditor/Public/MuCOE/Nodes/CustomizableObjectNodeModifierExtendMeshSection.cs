namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeModifierExtendMeshSection")]
    public class UCustomizableObjectNodeModifierExtendMeshSection : UCustomizableObjectNodeModifierWithMaterial
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}