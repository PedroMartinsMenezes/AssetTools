namespace AssetTool
{
    [JsonAsset("PCGMetadataBreakTransformSettings")]
    public class UPCGMetadataBreakTransformSettings : UPCGMetadataSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}