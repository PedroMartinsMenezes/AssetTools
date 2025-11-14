namespace AssetTool
{
    [JsonAsset("ExtrudeMeshSelectionToolBuilder")]
    public class UExtrudeMeshSelectionToolBuilder : USingleTargetWithSelectionToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ExtrudeMeshSelectionToolProperties")]
    public class UExtrudeMeshSelectionToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ExtrudeMeshSelectionTool")]
    public class UExtrudeMeshSelectionTool : USingleTargetWithSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}