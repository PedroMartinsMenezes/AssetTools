namespace AssetTool
{
    [JsonAsset("MeshWireframeComponent")]
    public class UMeshWireframeComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}