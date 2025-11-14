namespace AssetTool
{
    [JsonAsset("OnsetNRTSettings")]
    public class UOnsetNRTSettings : UAudioSynesthesiaNRTSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OnsetNRT")]
    public class UOnsetNRT : UAudioSynesthesiaNRT
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}