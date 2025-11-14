namespace AssetTool
{
    [JsonAsset("PCGTextureDataInterface")]
    public class UPCGTextureDataInterface : UPCGComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGTextureDataProvider")]
    public class UPCGTextureDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}