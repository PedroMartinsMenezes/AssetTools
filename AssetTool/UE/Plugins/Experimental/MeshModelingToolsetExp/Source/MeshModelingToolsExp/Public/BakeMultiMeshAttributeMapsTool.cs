namespace AssetTool
{
    [JsonAsset("BakeMultiMeshAttributeMapsToolBuilder")]
    public class UBakeMultiMeshAttributeMapsToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMultiMeshAttributeMapsToolProperties")]
    public class UBakeMultiMeshAttributeMapsToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMultiMeshInputToolProperties")]
    public class UBakeMultiMeshInputToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMultiMeshAttributeMapsTool")]
    public class UBakeMultiMeshAttributeMapsTool : UBakeMeshAttributeMapsToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}