namespace AssetTool
{
    [JsonAsset("SeamSculptToolBuilder")]
    public class USeamSculptToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SeamSculptToolProperties")]
    public class USeamSculptToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SeamSculptTool")]
    public class USeamSculptTool : UDynamicMeshBrushTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}