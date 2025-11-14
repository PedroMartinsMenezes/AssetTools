namespace AssetTool
{
    [JsonAsset("OptimusSkeletonDataInterface")]
    public class UOptimusSkeletonDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSkeletonDataProvider")]
    public class UOptimusSkeletonDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}