namespace AssetTool
{
    [JsonAsset("ConstantQNRTSettings")]
    public class UConstantQNRTSettings : UAudioSynesthesiaNRTSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConstantQNRT")]
    public class UConstantQNRT : UAudioSynesthesiaNRT
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}