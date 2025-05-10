namespace AssetTool
{
    [JsonAsset("OptimusAdvancedSkeletonDataInterface")]
    public class UOptimusAdvancedSkeletonDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusAdvancedSkeletonDataProvider")]
    public class UOptimusAdvancedSkeletonDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}