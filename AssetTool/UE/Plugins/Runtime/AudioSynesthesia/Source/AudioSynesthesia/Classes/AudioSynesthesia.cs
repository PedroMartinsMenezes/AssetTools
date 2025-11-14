namespace AssetTool
{
    [JsonAsset("AudioSynesthesiaSettings")]
    public class UAudioSynesthesiaSettings : UAudioAnalyzerSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}