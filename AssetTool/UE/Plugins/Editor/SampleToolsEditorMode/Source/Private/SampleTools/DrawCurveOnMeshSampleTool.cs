namespace AssetTool
{
    [JsonAsset("DrawCurveOnMeshSampleToolBuilder")]
    public class UDrawCurveOnMeshSampleToolBuilder : UMeshSurfacePointToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DrawCurveOnMeshSampleToolProperties")]
    public class UDrawCurveOnMeshSampleToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DrawCurveOnMeshSampleTool")]
    public class UDrawCurveOnMeshSampleTool : UMeshSurfacePointTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}