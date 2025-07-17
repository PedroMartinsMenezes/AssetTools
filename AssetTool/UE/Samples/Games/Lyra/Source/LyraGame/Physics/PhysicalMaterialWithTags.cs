namespace AssetTool
{
    [JsonAsset("PhysicalMaterialWithTags")]
    public class UPhysicalMaterialWithTags : UPhysicalMaterial
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}