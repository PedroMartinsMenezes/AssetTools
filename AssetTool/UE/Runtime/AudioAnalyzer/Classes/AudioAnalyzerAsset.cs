namespace AssetTool
{
    [JsonAsset("AudioAnalyzerAssetBase")]
    public class UAudioAnalyzerAssetBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}