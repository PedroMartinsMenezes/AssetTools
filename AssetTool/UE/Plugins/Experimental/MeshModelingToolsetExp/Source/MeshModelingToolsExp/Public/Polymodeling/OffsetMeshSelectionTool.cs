namespace AssetTool
{
    [JsonAsset("OffsetMeshSelectionToolBuilder")]
    public class UOffsetMeshSelectionToolBuilder : USingleTargetWithSelectionToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OffsetMeshSelectionToolProperties")]
    public class UOffsetMeshSelectionToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OffsetMeshSelectionTool")]
    public class UOffsetMeshSelectionTool : USingleTargetWithSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}