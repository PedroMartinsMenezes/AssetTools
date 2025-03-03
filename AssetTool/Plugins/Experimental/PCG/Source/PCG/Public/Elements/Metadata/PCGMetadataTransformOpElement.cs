namespace AssetTool
{
    [JsonAsset("PCGMetadataTransformSettings")]
    public class UPCGMetadataTransformSettings : UPCGMetadataSettingsBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}