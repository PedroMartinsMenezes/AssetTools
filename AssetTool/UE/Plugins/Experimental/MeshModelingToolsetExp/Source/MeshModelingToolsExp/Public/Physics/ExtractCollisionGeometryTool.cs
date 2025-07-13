namespace AssetTool
{
    [JsonAsset("ExtractCollisionGeometryToolBuilder")]
    public class UExtractCollisionGeometryToolBuilder : USingleSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ExtractCollisionToolProperties")]
    public class UExtractCollisionToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ExtractCollisionGeometryTool")]
    public class UExtractCollisionGeometryTool : USingleSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}