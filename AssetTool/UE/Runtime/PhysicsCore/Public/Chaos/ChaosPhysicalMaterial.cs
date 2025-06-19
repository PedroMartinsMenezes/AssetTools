namespace AssetTool
{
    [JsonAsset("ChaosPhysicalMaterial")]
    public class UChaosPhysicalMaterial : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}