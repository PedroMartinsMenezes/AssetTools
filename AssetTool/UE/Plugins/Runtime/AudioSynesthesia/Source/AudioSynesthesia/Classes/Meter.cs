namespace AssetTool
{
    [JsonAsset("MeterSettings")]
    public class UMeterSettings : UAudioSynesthesiaSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeterAnalyzer")]
    public class UMeterAnalyzer : UAudioAnalyzer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}