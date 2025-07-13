namespace AssetTool
{
    [JsonAsset("SkinWeightsBindingToolBuilder")]
    public class USkinWeightsBindingToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkinWeightsBindingToolProperties")]
    public class USkinWeightsBindingToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkinWeightsBindingTool")]
    public class USkinWeightsBindingTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}