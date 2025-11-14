namespace AssetTool
{
    [JsonAsset("PCGLandscapeDataInterface")]
    public class UPCGLandscapeDataInterface : UPCGComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGLandscapeDataProvider")]
    public class UPCGLandscapeDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}