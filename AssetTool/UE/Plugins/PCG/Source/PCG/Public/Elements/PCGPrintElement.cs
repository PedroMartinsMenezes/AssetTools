namespace AssetTool
{
    [JsonAsset("PCGManagedDebugStringMessageKey")]
    public class UPCGManagedDebugStringMessageKey : UPCGManagedResource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGPrintElementSettings")]
    public class UPCGPrintElementSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}