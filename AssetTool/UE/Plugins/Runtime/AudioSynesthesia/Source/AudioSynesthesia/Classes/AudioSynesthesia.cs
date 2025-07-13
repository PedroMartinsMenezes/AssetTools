namespace AssetTool
{
    [JsonAsset("AudioSynesthesiaSettings")]
    public class UAudioSynesthesiaSettings : UAudioAnalyzerSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}