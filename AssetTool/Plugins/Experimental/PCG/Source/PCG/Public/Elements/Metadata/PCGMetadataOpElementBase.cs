namespace AssetTool
{
    [JsonAsset("PCGMetadataSettingsBase")]
    public class UPCGMetadataSettingsBase : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}