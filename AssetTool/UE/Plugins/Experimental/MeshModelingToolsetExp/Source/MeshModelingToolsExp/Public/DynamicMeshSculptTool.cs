namespace AssetTool
{
    [JsonAsset("DynamicMeshSculptToolBuilder")]
    public class UDynamicMeshSculptToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DynamicMeshBrushProperties")]
    public class UDynamicMeshBrushProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DynamicMeshBrushSculptProperties")]
    public class UDynamicMeshBrushSculptProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DynamicSculptToolActions")]
    public class UDynamicSculptToolActions : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BrushRemeshProperties")]
    public class UBrushRemeshProperties : URemeshProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FixedPlaneBrushProperties")]
    public class UFixedPlaneBrushProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DynamicMeshSculptTool")]
    public class UDynamicMeshSculptTool : UMeshSurfacePointTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}