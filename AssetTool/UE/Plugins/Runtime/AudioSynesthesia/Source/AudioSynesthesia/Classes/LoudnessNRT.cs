namespace AssetTool
{
    [JsonAsset("LoudnessNRTSettings")]
    public class ULoudnessNRTSettings : UAudioSynesthesiaNRTSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LoudnessNRT")]
    public class ULoudnessNRT : UAudioSynesthesiaNRT
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}