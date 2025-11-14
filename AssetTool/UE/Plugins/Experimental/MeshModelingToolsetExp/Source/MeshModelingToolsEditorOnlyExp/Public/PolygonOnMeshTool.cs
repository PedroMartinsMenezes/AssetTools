namespace AssetTool
{
    [JsonAsset("PolygonOnMeshToolBuilder")]
    public class UPolygonOnMeshToolBuilder : USingleSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolygonOnMeshToolProperties")]
    public class UPolygonOnMeshToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolygonOnMeshToolActionPropertySet")]
    public class UPolygonOnMeshToolActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolygonOnMeshTool")]
    public class UPolygonOnMeshTool : USingleSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}