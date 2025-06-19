namespace AssetTool
{
    [JsonAsset("OptimusMorphTargetDataInterface")]
    public class UOptimusMorphTargetDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusMorphTargetDataProvider")]
    public class UOptimusMorphTargetDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}