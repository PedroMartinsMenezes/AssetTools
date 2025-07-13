namespace AssetTool
{
    [JsonAsset("MeshVertexPaintToolBuilder")]
    public class UMeshVertexPaintToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VertexPaintBasicProperties")]
    public class UVertexPaintBasicProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VertexPaintBrushFilterProperties")]
    public class UVertexPaintBrushFilterProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshVertexPaintToolActionPropertySet")]
    public class UMeshVertexPaintToolActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshVertexPaintToolQuickActions")]
    public class UMeshVertexPaintToolQuickActions : UMeshVertexPaintToolActionPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshVertexPaintToolUtilityActions")]
    public class UMeshVertexPaintToolUtilityActions : UMeshVertexPaintToolActionPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshVertexPaintTool")]
    public class UMeshVertexPaintTool : UMeshSculptToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}