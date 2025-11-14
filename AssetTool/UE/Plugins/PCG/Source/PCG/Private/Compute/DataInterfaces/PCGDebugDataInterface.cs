namespace AssetTool
{
    [JsonAsset("PCGDebugDataInterface")]
    public class UPCGDebugDataInterface : UComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDebugDataProvider")]
    public class UPCGDebugDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}