namespace AssetTool
{
    [JsonAsset("PCGVirtualTextureDataInterface")]
    public class UPCGVirtualTextureDataInterface : UPCGComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGVirtualTextureDataProvider")]
    public class UPCGVirtualTextureDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}