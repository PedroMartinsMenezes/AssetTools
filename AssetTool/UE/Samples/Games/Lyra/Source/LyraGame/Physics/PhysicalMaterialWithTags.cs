namespace AssetTool
{
    [JsonAsset("PhysicalMaterialWithTags")]
    public class UPhysicalMaterialWithTags : UPhysicalMaterial
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}