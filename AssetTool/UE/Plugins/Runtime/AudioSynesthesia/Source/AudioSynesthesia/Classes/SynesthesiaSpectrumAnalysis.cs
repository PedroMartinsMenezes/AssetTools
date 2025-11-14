namespace AssetTool
{
    [JsonAsset("SynesthesiaSpectrumAnalysisSettings")]
    public class USynesthesiaSpectrumAnalysisSettings : UAudioSynesthesiaSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SynesthesiaSpectrumAnalyzer")]
    public class USynesthesiaSpectrumAnalyzer : UAudioAnalyzer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}