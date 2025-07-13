namespace AssetTool
{
    [JsonAsset("MeterSettings")]
    public class UMeterSettings : UAudioSynesthesiaSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeterAnalyzer")]
    public class UMeterAnalyzer : UAudioAnalyzer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}