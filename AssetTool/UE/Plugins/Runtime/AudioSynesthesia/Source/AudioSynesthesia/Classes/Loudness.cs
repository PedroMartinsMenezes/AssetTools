namespace AssetTool
{
    [JsonAsset("LoudnessSettings")]
    public class ULoudnessSettings : UAudioSynesthesiaSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LoudnessAnalyzer")]
    public class ULoudnessAnalyzer : UAudioAnalyzer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}