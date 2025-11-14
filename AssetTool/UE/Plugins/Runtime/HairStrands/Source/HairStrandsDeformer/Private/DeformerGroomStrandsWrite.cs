namespace AssetTool
{
    [JsonAsset("OptimusGroomStrandsWriteDataInterface")]
    public class UOptimusGroomStrandsWriteDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomStrandsWriteDataProvider")]
    public class UOptimusGroomStrandsWriteDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}