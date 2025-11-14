namespace AssetTool
{
    [JsonAsset("PCGDataNumDataInterface")]
    public class UPCGDataNumDataInterface : UPCGComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDataNumDataProvider")]
    public class UPCGDataNumDataProvider : UPCGComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}