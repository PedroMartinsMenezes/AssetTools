namespace AssetTool
{
    [JsonAsset("PCGVirtualTextureDataInterface")]
    public class UPCGVirtualTextureDataInterface : UPCGComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGVirtualTextureDataProvider")]
    public class UPCGVirtualTextureDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}