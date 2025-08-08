namespace AssetTool
{
    [JsonAsset("PCGDataNumDataInterface")]
    public class UPCGDataNumDataInterface : UPCGComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDataNumDataProvider")]
    public class UPCGDataNumDataProvider : UPCGComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}