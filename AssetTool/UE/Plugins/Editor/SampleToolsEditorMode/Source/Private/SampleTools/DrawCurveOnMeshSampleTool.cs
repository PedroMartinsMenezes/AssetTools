namespace AssetTool
{
    [JsonAsset("DrawCurveOnMeshSampleToolBuilder")]
    public class UDrawCurveOnMeshSampleToolBuilder : UMeshSurfacePointToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DrawCurveOnMeshSampleToolProperties")]
    public class UDrawCurveOnMeshSampleToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DrawCurveOnMeshSampleTool")]
    public class UDrawCurveOnMeshSampleTool : UMeshSurfacePointTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}