namespace AssetTool
{
    [JsonAsset("MeshVertexSculptToolBuilder")]
    public class UMeshVertexSculptToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VertexBrushSculptProperties")]
    public class UVertexBrushSculptProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VertexBrushAlphaProperties")]
    public class UVertexBrushAlphaProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSymmetryProperties")]
    public class UMeshSymmetryProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshVertexSculptTool")]
    public class UMeshVertexSculptTool : UMeshSculptToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}