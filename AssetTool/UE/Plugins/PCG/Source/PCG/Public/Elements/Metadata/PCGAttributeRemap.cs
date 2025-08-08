namespace AssetTool
{
    [JsonAsset("PCGAttributeRemapSettings")]
    public class UPCGAttributeRemapSettings : UPCGMetadataSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}