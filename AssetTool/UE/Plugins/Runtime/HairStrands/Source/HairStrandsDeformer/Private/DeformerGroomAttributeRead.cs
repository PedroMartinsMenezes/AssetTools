namespace AssetTool
{
    [JsonAsset("OptimusGroomAttributeReadDataInterface")]
    public class UOptimusGroomAttributeReadDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomAttributeReadDataProvider")]
    public class UOptimusGroomAttributeReadDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}