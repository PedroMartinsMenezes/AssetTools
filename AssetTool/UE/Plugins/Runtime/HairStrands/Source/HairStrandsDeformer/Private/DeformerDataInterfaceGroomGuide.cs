namespace AssetTool
{
    [JsonAsset("OptimusGroomGuideDataInterface")]
    public class UOptimusGroomGuideDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomGuideDataProvider")]
    public class UOptimusGroomGuideDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}