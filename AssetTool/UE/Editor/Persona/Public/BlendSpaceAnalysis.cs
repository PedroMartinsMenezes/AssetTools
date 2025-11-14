namespace AssetTool
{
    [JsonAsset("CachedAnalysisProperties")]
    public class UCachedAnalysisProperties : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LinearAnalysisProperties")]
    public class ULinearAnalysisProperties : UAnalysisProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EulerAnalysisProperties")]
    public class UEulerAnalysisProperties : UAnalysisProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}