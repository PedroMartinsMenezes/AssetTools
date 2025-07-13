namespace AssetTool
{
    [JsonAsset("ExtrudeMeshSelectionToolBuilder")]
    public class UExtrudeMeshSelectionToolBuilder : USingleTargetWithSelectionToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ExtrudeMeshSelectionToolProperties")]
    public class UExtrudeMeshSelectionToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ExtrudeMeshSelectionTool")]
    public class UExtrudeMeshSelectionTool : USingleTargetWithSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}