namespace AssetTool
{
    [JsonAsset("OptimusConnectivityDataInterface")]
    public class UOptimusConnectivityDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusConnectivityDataProvider")]
    public class UOptimusConnectivityDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}