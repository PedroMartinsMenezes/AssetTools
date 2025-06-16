namespace AssetTool
{
    [JsonAsset("PCGAttributeRemapSettings")]
    public class UPCGAttributeRemapSettings : UPCGMetadataSettingsBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}