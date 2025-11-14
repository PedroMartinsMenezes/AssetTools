namespace AssetTool
{
    [JsonAsset("EditNormalsToolBuilder")]
    public class UEditNormalsToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditNormalsToolProperties")]
    public class UEditNormalsToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditNormalsOperatorFactory")]
    public class UEditNormalsOperatorFactory : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditNormalsTool")]
    public class UEditNormalsTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}