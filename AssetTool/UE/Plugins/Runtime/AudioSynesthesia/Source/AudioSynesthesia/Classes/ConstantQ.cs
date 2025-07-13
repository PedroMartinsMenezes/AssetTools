namespace AssetTool
{
    [JsonAsset("ConstantQSettings")]
    public class UConstantQSettings : UAudioSynesthesiaSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConstantQAnalyzer")]
    public class UConstantQAnalyzer : UAudioAnalyzer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}