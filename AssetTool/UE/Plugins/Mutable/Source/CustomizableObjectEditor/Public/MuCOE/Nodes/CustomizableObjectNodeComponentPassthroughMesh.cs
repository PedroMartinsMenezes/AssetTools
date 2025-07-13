namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeComponentMeshPinDataSection")]
    public class UCustomizableObjectNodeComponentMeshPinDataSection : UCustomizableObjectNodePinData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeComponentMeshPinDataMaterial")]
    public class UCustomizableObjectNodeComponentMeshPinDataMaterial : UCustomizableObjectNodeComponentMeshPinDataSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeComponentPassthroughMesh")]
    public class UCustomizableObjectNodeComponentPassthroughMesh : UCustomizableObjectNodeComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}