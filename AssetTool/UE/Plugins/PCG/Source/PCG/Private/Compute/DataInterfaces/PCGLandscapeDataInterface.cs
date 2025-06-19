namespace AssetTool
{
    [JsonAsset("PCGLandscapeDataInterface")]
    public class UPCGLandscapeDataInterface : UPCGComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGLandscapeDataProvider")]
    public class UPCGLandscapeDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}