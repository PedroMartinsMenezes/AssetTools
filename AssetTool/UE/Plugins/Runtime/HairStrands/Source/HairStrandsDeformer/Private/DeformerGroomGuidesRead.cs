namespace AssetTool
{
    [JsonAsset("OptimusGroomGuidesReadDataInterface")]
    public class UOptimusGroomGuidesReadDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomGuidesReadDataProvider")]
    public class UOptimusGroomGuidesReadDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}