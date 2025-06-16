namespace AssetTool
{
    [JsonAsset("PCGMetadataMakeTransformSettings")]
    public class UPCGMetadataMakeTransformSettings : UPCGMetadataSettingsBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}