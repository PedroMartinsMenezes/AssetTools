namespace AssetTool
{
    [JsonAsset("NewMeshMaterialProperties")]
    public class UNewMeshMaterialProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ExistingMeshMaterialProperties")]
    public class UExistingMeshMaterialProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshEditingViewProperties")]
    public class UMeshEditingViewProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}