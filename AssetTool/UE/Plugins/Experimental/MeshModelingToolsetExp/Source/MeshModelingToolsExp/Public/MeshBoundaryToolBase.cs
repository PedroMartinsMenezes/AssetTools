namespace AssetTool
{
    [JsonAsset("MeshBoundaryToolBase")]
    public class UMeshBoundaryToolBase : USingleSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}