namespace AssetTool
{
    [JsonAsset("PCGInstanceDataInterface")]
    public class UPCGInstanceDataInterface : UPCGComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGInstanceDataProvider")]
    public class UPCGInstanceDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}