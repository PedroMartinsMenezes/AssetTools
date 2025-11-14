namespace AssetTool
{
    [JsonAsset("PhysicalMaterial")]
    public class UPhysicalMaterial : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}