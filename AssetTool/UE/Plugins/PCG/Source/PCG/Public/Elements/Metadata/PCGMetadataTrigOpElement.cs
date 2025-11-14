namespace AssetTool
{
    [JsonAsset("PCGMetadataTrigSettings")]
    public class UPCGMetadataTrigSettings : UPCGMetadataSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}