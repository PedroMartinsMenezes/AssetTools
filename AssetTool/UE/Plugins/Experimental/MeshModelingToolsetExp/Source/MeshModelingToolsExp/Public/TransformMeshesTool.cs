namespace AssetTool
{
    [JsonAsset("TransformMeshesToolBuilder")]
    public class UTransformMeshesToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TransformMeshesToolProperties")]
    public class UTransformMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TransformMeshesTool")]
    public class UTransformMeshesTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}