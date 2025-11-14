namespace AssetTool
{
    [JsonAsset("ChaosPhysicalMaterial")]
    public class UChaosPhysicalMaterial : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}