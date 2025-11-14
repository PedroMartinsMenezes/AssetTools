namespace AssetTool
{
    [JsonAsset("DataflowEditorWeightMapPaintToolBuilder")]
    public class UDataflowEditorWeightMapPaintToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataflowEditorWeightMapPaintBrushFilterProperties")]
    public class UDataflowEditorWeightMapPaintBrushFilterProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataflowEditorMeshWeightMapPaintToolActions")]
    public class UDataflowEditorMeshWeightMapPaintToolActions : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataflowEditorUpdateWeightMapProperties")]
    public class UDataflowEditorUpdateWeightMapProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataflowEditorWeightMapPaintTool")]
    public class UDataflowEditorWeightMapPaintTool : UMeshSculptToolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}