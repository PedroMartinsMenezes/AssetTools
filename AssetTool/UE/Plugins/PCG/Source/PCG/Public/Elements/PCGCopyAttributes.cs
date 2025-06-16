namespace AssetTool
{
    [JsonAsset("PCGCopyAttributesSettings")]
    public class UPCGCopyAttributesSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}