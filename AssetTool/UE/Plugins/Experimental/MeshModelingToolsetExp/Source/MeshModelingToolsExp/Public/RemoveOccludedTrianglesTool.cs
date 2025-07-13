namespace AssetTool
{
    [JsonAsset("RemoveOccludedTrianglesToolBuilder")]
    public class URemoveOccludedTrianglesToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoveOccludedTrianglesToolProperties")]
    public class URemoveOccludedTrianglesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoveOccludedTrianglesAdvancedProperties")]
    public class URemoveOccludedTrianglesAdvancedProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoveOccludedTrianglesOperatorFactory")]
    public class URemoveOccludedTrianglesOperatorFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoveOccludedTrianglesTool")]
    public class URemoveOccludedTrianglesTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}