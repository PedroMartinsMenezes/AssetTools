namespace AssetTool
{
    [JsonAsset("PCGCopyAttributesSettings")]
    public class UPCGCopyAttributesSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}