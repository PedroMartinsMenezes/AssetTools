namespace AssetTool
{
    [JsonAsset("OptimusSkeletonDataInterface")]
    public class UOptimusSkeletonDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSkeletonDataProvider")]
    public class UOptimusSkeletonDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}