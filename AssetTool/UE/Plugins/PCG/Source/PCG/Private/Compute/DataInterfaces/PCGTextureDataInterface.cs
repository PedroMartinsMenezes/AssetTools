namespace AssetTool
{
    [JsonAsset("PCGTextureDataInterface")]
    public class UPCGTextureDataInterface : UPCGComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGTextureDataProvider")]
    public class UPCGTextureDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}