namespace AssetTool
{
    [JsonAsset("PCGCopyPointsAnalysisDataInterface")]
    public class UPCGCopyPointsAnalysisDataInterface : UPCGComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGCopyPointsAnalysisDataProvider")]
    public class UPCGCopyPointsAnalysisDataProvider : UPCGComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}