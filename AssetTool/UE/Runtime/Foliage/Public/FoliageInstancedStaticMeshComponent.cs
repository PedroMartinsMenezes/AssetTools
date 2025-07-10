namespace AssetTool
{
    [JsonAsset("FoliageInstancedStaticMeshComponent")]
    public class UFoliageInstancedStaticMeshComponent : UHierarchicalInstancedStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}