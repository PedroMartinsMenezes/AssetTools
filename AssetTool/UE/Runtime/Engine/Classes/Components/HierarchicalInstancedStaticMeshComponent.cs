namespace AssetTool
{
    [JsonAsset("HierarchicalInstancedStaticMeshComponent")]
    public class UHierarchicalInstancedStaticMeshComponent : UInstancedStaticMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}