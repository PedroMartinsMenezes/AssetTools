namespace AssetTool
{
    [JsonAsset("BakeMeshAttributeMapsToolBuilder")]
    public class UBakeMeshAttributeMapsToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMeshAttributeMapsToolProperties")]
    public class UBakeMeshAttributeMapsToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMeshAttributeMapsTool")]
    public class UBakeMeshAttributeMapsTool : UBakeMeshAttributeMapsToolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}