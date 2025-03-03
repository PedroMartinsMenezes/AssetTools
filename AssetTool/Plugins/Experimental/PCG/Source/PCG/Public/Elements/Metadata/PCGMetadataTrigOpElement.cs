namespace AssetTool
{
    [JsonAsset("PCGMetadataTrigSettings")]
    public class UPCGMetadataTrigSettings : UPCGMetadataSettingsBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}