namespace AssetTool
{
    [JsonAsset("OptimusGroomStrandsReadDataInterface")]
    public class UOptimusGroomStrandsReadDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomStrandsReadDataProvider")]
    public class UOptimusGroomStrandsReadDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}