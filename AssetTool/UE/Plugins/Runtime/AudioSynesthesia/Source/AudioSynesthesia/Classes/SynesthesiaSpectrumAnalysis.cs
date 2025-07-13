namespace AssetTool
{
    [JsonAsset("SynesthesiaSpectrumAnalysisSettings")]
    public class USynesthesiaSpectrumAnalysisSettings : UAudioSynesthesiaSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SynesthesiaSpectrumAnalyzer")]
    public class USynesthesiaSpectrumAnalyzer : UAudioAnalyzer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}