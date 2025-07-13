namespace AssetTool
{
    [JsonAsset("SetCollisionGeometryToolBuilder")]
    public class USetCollisionGeometryToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SetCollisionGeometryToolProperties")]
    public class USetCollisionGeometryToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SetCollisionGeometryTool")]
    public class USetCollisionGeometryTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}