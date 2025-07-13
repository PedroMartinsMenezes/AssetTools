namespace AssetTool
{
    [JsonAsset("AudioSynesthesiaNRTSettings")]
    public class UAudioSynesthesiaNRTSettings : UAudioAnalyzerNRTSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioSynesthesiaNRT")]
    public class UAudioSynesthesiaNRT : UAudioAnalyzerNRT
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}