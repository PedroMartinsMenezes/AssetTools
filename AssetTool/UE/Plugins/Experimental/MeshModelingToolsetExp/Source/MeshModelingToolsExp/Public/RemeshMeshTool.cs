namespace AssetTool
{
    [JsonAsset("RemeshMeshToolBuilder")]
    public class URemeshMeshToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemeshMeshToolProperties")]
    public class URemeshMeshToolProperties : URemeshProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemeshMeshTool")]
    public class URemeshMeshTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}