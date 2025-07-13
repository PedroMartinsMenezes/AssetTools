namespace AssetTool
{
    [JsonAsset("OptimusGroomDataInterface")]
    public class UOptimusGroomDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomDataProvider")]
    public class UOptimusGroomDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}