namespace AssetTool
{
    [JsonAsset("FoliageInstancedStaticMeshComponent")]
    public class UFoliageInstancedStaticMeshComponent : UHierarchicalInstancedStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}