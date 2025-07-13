namespace AssetTool
{
    [JsonAsset("AudioAnalyzerNRTSettings")]
    public class UAudioAnalyzerNRTSettings : UAudioAnalyzerAssetBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioAnalyzerNRT")]
    public class UAudioAnalyzerNRT : UAudioAnalyzerAssetBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}