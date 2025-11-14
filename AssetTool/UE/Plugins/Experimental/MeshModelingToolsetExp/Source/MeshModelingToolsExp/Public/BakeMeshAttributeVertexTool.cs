namespace AssetTool
{
    [JsonAsset("BakeMeshAttributeVertexToolBuilder")]
    public class UBakeMeshAttributeVertexToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMeshAttributeVertexToolProperties")]
    public class UBakeMeshAttributeVertexToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMeshAttributeVertexTool")]
    public class UBakeMeshAttributeVertexTool : UBakeMeshAttributeTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}