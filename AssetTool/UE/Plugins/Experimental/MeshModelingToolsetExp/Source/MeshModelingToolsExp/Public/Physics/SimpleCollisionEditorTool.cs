namespace AssetTool
{
    [JsonAsset("SimpleCollisionEditorToolBuilder")]
    public class USimpleCollisionEditorToolBuilder : USingleSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SimpleCollisionEditorToolActionProperties")]
    public class USimpleCollisionEditorToolActionProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SimpleCollisionEditorTool")]
    public class USimpleCollisionEditorTool : USingleSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}