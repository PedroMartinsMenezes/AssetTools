namespace AssetTool
{
    [JsonAsset("CombineMeshesToolBuilder")]
    public class UCombineMeshesToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CombineMeshesToolProperties")]
    public class UCombineMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CombineMeshesTool")]
    public class UCombineMeshesTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}