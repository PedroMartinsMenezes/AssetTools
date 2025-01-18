namespace AssetTool
{
    [JsonAsset("OptimusClothDataInterface")]
    public class UOptimusClothDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusClothDataProvider")]
    public class UOptimusClothDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}