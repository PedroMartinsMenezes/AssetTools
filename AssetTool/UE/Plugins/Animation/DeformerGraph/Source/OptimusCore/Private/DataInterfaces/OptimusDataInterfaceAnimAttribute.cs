namespace AssetTool
{
    [JsonAsset("OptimusAnimAttributeDataInterface")]
    public class UOptimusAnimAttributeDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusAnimAttributeDataProvider")]
    public class UOptimusAnimAttributeDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}