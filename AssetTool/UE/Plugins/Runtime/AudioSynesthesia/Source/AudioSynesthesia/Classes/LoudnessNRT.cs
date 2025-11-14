namespace AssetTool
{
    [JsonAsset("LoudnessNRTSettings")]
    public class ULoudnessNRTSettings : UAudioSynesthesiaNRTSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LoudnessNRT")]
    public class ULoudnessNRT : UAudioSynesthesiaNRT
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}