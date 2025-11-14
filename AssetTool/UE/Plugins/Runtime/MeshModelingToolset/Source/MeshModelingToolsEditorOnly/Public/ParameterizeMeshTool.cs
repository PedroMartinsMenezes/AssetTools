namespace AssetTool
{
    [JsonAsset("ParameterizeMeshToolBuilder")]
    public class UParameterizeMeshToolBuilder : USingleSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ParameterizeMeshTool")]
    public class UParameterizeMeshTool : USingleSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}