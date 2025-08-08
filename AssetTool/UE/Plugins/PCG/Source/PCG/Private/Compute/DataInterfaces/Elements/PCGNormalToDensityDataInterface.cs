namespace AssetTool
{
    [JsonAsset("PCGNormalToDensityDataInterface")]
    public class UPCGNormalToDensityDataInterface : UPCGComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGNormalToDensityProvider")]
    public class UPCGNormalToDensityProvider : UPCGComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}