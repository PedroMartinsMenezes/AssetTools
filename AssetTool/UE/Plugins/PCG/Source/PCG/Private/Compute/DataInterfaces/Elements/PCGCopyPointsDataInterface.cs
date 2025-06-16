namespace AssetTool
{
    [JsonAsset("PCGCopyPointsDataInterface")]
    public class UPCGCopyPointsDataInterface : UPCGComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGCopyPointsDataProvider")]
    public class UPCGCopyPointsDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}