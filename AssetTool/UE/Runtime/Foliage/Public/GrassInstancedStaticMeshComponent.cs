namespace AssetTool
{
    [JsonAsset("GrassInstancedStaticMeshComponent")]
    public class UGrassInstancedStaticMeshComponent : UHierarchicalInstancedStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}