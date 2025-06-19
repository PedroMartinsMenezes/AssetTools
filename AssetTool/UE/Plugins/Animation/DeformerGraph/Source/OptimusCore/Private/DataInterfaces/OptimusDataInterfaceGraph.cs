namespace AssetTool
{
    [JsonAsset("OptimusGraphDataInterface")]
    public class UOptimusGraphDataInterface : UComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGraphDataProvider")]
    public class UOptimusGraphDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}