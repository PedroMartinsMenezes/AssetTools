namespace AssetTool
{
    [JsonAsset("PhysicsInspectorToolBuilder")]
    public class UPhysicsInspectorToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PhysicsInspectorTool")]
    public class UPhysicsInspectorTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}