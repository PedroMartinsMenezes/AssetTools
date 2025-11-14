namespace AssetTool
{
    [JsonAsset("ConstantQSettings")]
    public class UConstantQSettings : UAudioSynesthesiaSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConstantQAnalyzer")]
    public class UConstantQAnalyzer : UAudioAnalyzer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}