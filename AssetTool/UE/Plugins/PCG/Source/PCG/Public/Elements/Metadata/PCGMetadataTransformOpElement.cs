namespace AssetTool
{
    [JsonAsset("PCGMetadataTransformSettings")]
    public class UPCGMetadataTransformSettings : UPCGMetadataSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}