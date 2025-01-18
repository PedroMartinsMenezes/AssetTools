namespace AssetTool
{
    [JsonAsset("OptimusConnectivityDataInterface")]
    public class UOptimusConnectivityDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusConnectivityDataProvider")]
    public class UOptimusConnectivityDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}