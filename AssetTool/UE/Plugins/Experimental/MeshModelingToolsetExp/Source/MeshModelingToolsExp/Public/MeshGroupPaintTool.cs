namespace AssetTool
{
    [JsonAsset("MeshGroupPaintToolBuilder")]
    public class UMeshGroupPaintToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GroupPaintBrushFilterProperties")]
    public class UGroupPaintBrushFilterProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshGroupPaintToolActionPropertySet")]
    public class UMeshGroupPaintToolActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshGroupPaintToolFreezeActions")]
    public class UMeshGroupPaintToolFreezeActions : UMeshGroupPaintToolActionPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshGroupPaintTool")]
    public class UMeshGroupPaintTool : UMeshSculptToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}