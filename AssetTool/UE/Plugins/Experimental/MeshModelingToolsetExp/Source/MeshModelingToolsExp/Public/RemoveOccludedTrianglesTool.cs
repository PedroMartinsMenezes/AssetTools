namespace AssetTool
{
    [JsonAsset("RemoveOccludedTrianglesToolBuilder")]
    public class URemoveOccludedTrianglesToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoveOccludedTrianglesToolProperties")]
    public class URemoveOccludedTrianglesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoveOccludedTrianglesAdvancedProperties")]
    public class URemoveOccludedTrianglesAdvancedProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoveOccludedTrianglesOperatorFactory")]
    public class URemoveOccludedTrianglesOperatorFactory : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoveOccludedTrianglesTool")]
    public class URemoveOccludedTrianglesTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}