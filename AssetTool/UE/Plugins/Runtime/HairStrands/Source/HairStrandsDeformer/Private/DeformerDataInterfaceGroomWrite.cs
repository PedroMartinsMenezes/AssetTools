namespace AssetTool
{
    [JsonAsset("OptimusGroomWriteDataInterface")]
    public class UOptimusGroomWriteDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomWriteDataProvider")]
    public class UOptimusGroomWriteDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}