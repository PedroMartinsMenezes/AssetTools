namespace AssetTool
{
    [JsonAsset("PCGMetadataBreakTransformSettings")]
    public class UPCGMetadataBreakTransformSettings : UPCGMetadataSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}