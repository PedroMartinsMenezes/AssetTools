namespace AssetTool
{
    [JsonAsset("PhysicalMaterial")]
    public class UPhysicalMaterial : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}