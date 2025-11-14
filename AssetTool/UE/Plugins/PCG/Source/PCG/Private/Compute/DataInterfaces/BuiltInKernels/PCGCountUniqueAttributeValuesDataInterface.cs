namespace AssetTool
{
    [JsonAsset("PCGCountUniqueAttributeValuesDataInterface")]
    public class UPCGCountUniqueAttributeValuesDataInterface : UPCGComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGCountUniqueAttributeValuesDataProvider")]
    public class UPCGCountUniqueAttributeValuesDataProvider : UPCGComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGComputeDataProvider")]
    public class UPCGComputeDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}