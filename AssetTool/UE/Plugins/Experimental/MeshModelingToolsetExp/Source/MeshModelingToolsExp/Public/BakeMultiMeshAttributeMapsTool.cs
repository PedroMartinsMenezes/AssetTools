namespace AssetTool
{
    [JsonAsset("BakeMultiMeshAttributeMapsToolBuilder")]
    public class UBakeMultiMeshAttributeMapsToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMultiMeshAttributeMapsToolProperties")]
    public class UBakeMultiMeshAttributeMapsToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMultiMeshInputToolProperties")]
    public class UBakeMultiMeshInputToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMultiMeshAttributeMapsTool")]
    public class UBakeMultiMeshAttributeMapsTool : UBakeMeshAttributeMapsToolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}