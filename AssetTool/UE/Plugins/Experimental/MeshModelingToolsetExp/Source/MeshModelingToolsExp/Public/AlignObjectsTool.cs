namespace AssetTool
{
    [JsonAsset("AlignObjectsToolBuilder")]
    public class UAlignObjectsToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AlignObjectsToolProperties")]
    public class UAlignObjectsToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AlignObjectsTool")]
    public class UAlignObjectsTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}