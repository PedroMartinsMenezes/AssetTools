namespace AssetTool
{
    [JsonAsset("PCGCopyPointsDataInterface")]
    public class UPCGCopyPointsDataInterface : UPCGComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGCopyPointsDataProvider")]
    public class UPCGCopyPointsDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}