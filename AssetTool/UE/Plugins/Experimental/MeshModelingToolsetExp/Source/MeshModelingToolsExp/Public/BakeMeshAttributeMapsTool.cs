namespace AssetTool
{
    [JsonAsset("BakeMeshAttributeMapsToolBuilder")]
    public class UBakeMeshAttributeMapsToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMeshAttributeMapsToolProperties")]
    public class UBakeMeshAttributeMapsToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMeshAttributeMapsTool")]
    public class UBakeMeshAttributeMapsTool : UBakeMeshAttributeMapsToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}