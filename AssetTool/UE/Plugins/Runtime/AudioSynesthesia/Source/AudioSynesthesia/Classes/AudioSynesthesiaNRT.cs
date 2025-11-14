namespace AssetTool
{
    [JsonAsset("AudioSynesthesiaNRTSettings")]
    public class UAudioSynesthesiaNRTSettings : UAudioAnalyzerNRTSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioSynesthesiaNRT")]
    public class UAudioSynesthesiaNRT : UAudioAnalyzerNRT
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}