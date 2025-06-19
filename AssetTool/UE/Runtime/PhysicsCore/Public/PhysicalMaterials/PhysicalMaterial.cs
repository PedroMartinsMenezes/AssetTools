namespace AssetTool
{
    [JsonAsset("PhysicalMaterial")]
    public class UPhysicalMaterial : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}