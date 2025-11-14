namespace AssetTool
{
    [JsonAsset("ARLightEstimate")]
    public class UARLightEstimate : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARBasicLightEstimate")]
    public class UARBasicLightEstimate : UARLightEstimate
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}