namespace AssetTool
{
    [JsonAsset("EditUVIslandsToolBuilder")]
    public class UEditUVIslandsToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditUVIslandsTool")]
    public class UEditUVIslandsTool : UMeshSurfacePointTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}