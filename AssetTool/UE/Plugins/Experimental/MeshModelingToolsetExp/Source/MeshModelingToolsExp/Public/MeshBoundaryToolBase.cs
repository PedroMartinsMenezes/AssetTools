namespace AssetTool
{
    [JsonAsset("MeshBoundaryToolBase")]
    public class UMeshBoundaryToolBase : USingleSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}