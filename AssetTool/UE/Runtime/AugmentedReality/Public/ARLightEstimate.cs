namespace AssetTool
{
    [JsonAsset("ARLightEstimate")]
    public class UARLightEstimate : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARBasicLightEstimate")]
    public class UARBasicLightEstimate : UARLightEstimate
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}