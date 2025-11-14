namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeComponentMesh")]
    public class UCustomizableObjectNodeComponentMesh : UCustomizableObjectNodeComponentMeshBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}