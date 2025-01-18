namespace AssetTool
{
    [JsonAsset("OptimusGraphDataInterface")]
    public class UOptimusGraphDataInterface : UComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGraphDataProvider")]
    public class UOptimusGraphDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}