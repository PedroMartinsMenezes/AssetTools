namespace AssetTool
{
    [JsonAsset("PCGManagedDebugStringMessageKey")]
    public class UPCGManagedDebugStringMessageKey : UPCGManagedResource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGPrintElementSettings")]
    public class UPCGPrintElementSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}