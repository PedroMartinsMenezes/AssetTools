namespace AssetTool
{
    [JsonAsset("OptimusAdvancedSkeletonDataInterface")]
    public class UOptimusAdvancedSkeletonDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusAdvancedSkeletonDataProvider")]
    public class UOptimusAdvancedSkeletonDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}