namespace AssetTool
{
    [JsonAsset("SplitMeshesToolBuilder")]
    public class USplitMeshesToolBuilder : UMultiTargetWithSelectionToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SplitMeshesToolProperties")]
    public class USplitMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SplitMeshesTool")]
    public class USplitMeshesTool : UMultiTargetWithSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}