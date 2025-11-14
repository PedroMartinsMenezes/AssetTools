namespace AssetTool
{
    [JsonAsset("AudioAnalyzerSettings")]
    public class UAudioAnalyzerSettings : UAudioAnalyzerAssetBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioAnalyzer")]
    public class UAudioAnalyzer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}