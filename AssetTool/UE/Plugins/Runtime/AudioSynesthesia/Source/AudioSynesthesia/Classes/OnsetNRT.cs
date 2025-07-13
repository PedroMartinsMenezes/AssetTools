namespace AssetTool
{
    [JsonAsset("OnsetNRTSettings")]
    public class UOnsetNRTSettings : UAudioSynesthesiaNRTSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OnsetNRT")]
    public class UOnsetNRT : UAudioSynesthesiaNRT
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}