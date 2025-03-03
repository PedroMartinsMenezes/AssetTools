namespace AssetTool
{
    [JsonAsset("PCGMetadataRotatorSettings")]
    public class UPCGMetadataRotatorSettings : UPCGMetadataSettingsBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}