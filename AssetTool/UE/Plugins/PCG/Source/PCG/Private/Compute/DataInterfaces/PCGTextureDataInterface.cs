namespace AssetTool
{
    [JsonAsset("PCGTextureDataInterface")]
    public class UPCGTextureDataInterface : UPCGComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGTextureDataProvider")]
    public class UPCGTextureDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}