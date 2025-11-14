namespace AssetTool
{
    [JsonAsset("GrassInstancedStaticMeshComponent")]
    public class UGrassInstancedStaticMeshComponent : UHierarchicalInstancedStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}