namespace AssetTool
{
    [JsonAsset("OffsetMeshSelectionToolBuilder")]
    public class UOffsetMeshSelectionToolBuilder : USingleTargetWithSelectionToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OffsetMeshSelectionToolProperties")]
    public class UOffsetMeshSelectionToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OffsetMeshSelectionTool")]
    public class UOffsetMeshSelectionTool : USingleTargetWithSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}