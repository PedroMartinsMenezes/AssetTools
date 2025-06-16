namespace AssetTool
{
    [JsonAsset("PCGLandscapeDataInterface")]
    public class UPCGLandscapeDataInterface : UPCGComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGLandscapeDataProvider")]
    public class UPCGLandscapeDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}