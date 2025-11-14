namespace AssetTool
{
    [JsonAsset("OptimusAdvancedSkeletonDataInterface")]
    public class UOptimusAdvancedSkeletonDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusAdvancedSkeletonDataProvider")]
    public class UOptimusAdvancedSkeletonDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}