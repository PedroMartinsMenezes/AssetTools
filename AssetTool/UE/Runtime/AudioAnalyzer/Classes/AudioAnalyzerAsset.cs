namespace AssetTool
{
    [JsonAsset("AudioAnalyzerAssetBase")]
    public class UAudioAnalyzerAssetBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}