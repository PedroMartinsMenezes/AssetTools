namespace AssetTool
{
    [JsonAsset("MeshConstraintProperties")]
    public class UMeshConstraintProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemeshProperties")]
    public class URemeshProperties : UMeshConstraintProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}