namespace AssetTool
{
    [JsonAsset("MeshSurfacePointToolBuilder")]
    public class UMeshSurfacePointToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSurfacePointTool")]
    public class UMeshSurfacePointTool : USingleSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}