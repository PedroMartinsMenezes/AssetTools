namespace AssetTool
{
    [JsonAsset("LoudnessSettings")]
    public class ULoudnessSettings : UAudioSynesthesiaSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LoudnessAnalyzer")]
    public class ULoudnessAnalyzer : UAudioAnalyzer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}