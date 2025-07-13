namespace AssetTool
{
    [JsonAsset("SubdividePolyToolBuilder")]
    public class USubdividePolyToolBuilder : USingleSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SubdividePolyToolProperties")]
    public class USubdividePolyToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SubdividePolyTool")]
    public class USubdividePolyTool : USingleSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}