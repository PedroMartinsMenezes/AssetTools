namespace AssetTool
{
    [JsonAsset("PCGDataLabelResolverDataInterface")]
    public class UPCGDataLabelResolverDataInterface : UPCGComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDataLabelResolverDataProvider")]
    public class UPCGDataLabelResolverDataProvider : UPCGComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}