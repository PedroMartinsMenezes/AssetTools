namespace AssetTool
{
    [JsonAsset("OptimusSkeletonDataInterface")]
    public class UOptimusSkeletonDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSkeletonDataProvider")]
    public class UOptimusSkeletonDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}