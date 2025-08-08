namespace AssetTool
{
    [JsonAsset("PCGDataLabelResolverDataInterface")]
    public class UPCGDataLabelResolverDataInterface : UPCGComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDataLabelResolverDataProvider")]
    public class UPCGDataLabelResolverDataProvider : UPCGComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}