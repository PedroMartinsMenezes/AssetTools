namespace AssetTool
{
    [JsonAsset("OptimusGroomGuidesWriteDataInterface")]
    public class UOptimusGroomGuidesWriteDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomGuidesWriteDataProvider")]
    public class UOptimusGroomGuidesWriteDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}