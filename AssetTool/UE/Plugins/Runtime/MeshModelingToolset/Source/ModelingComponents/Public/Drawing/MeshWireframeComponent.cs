namespace AssetTool
{
    [JsonAsset("MeshWireframeComponent")]
    public class UMeshWireframeComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}