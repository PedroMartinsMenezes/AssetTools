namespace AssetTool
{
    [JsonAsset("MeshConstraintProperties")]
    public class UMeshConstraintProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemeshProperties")]
    public class URemeshProperties : UMeshConstraintProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}