namespace AssetTool
{
    [JsonAsset("OptimusGroomStrandsReadDataInterface")]
    public class UOptimusGroomStrandsReadDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomStrandsReadDataProvider")]
    public class UOptimusGroomStrandsReadDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}