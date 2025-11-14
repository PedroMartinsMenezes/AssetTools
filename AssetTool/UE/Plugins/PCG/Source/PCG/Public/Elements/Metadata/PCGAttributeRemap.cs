namespace AssetTool
{
    [JsonAsset("PCGAttributeRemapSettings")]
    public class UPCGAttributeRemapSettings : UPCGMetadataSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}