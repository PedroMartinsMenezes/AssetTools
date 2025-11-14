namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeComponentMeshPinDataSection")]
    public class UCustomizableObjectNodeComponentMeshPinDataSection : UCustomizableObjectNodePinData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeComponentMeshPinDataMaterial")]
    public class UCustomizableObjectNodeComponentMeshPinDataMaterial : UCustomizableObjectNodeComponentMeshPinDataSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeComponentPassthroughMesh")]
    public class UCustomizableObjectNodeComponentPassthroughMesh : UCustomizableObjectNodeComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}