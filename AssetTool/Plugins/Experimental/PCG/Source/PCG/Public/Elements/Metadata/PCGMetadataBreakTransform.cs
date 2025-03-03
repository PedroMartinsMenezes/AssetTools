namespace AssetTool
{
    [JsonAsset("PCGMetadataBreakTransformSettings")]
    public class UPCGMetadataBreakTransformSettings : UPCGMetadataSettingsBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}