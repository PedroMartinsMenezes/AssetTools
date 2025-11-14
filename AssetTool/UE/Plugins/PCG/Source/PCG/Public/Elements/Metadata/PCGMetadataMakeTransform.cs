namespace AssetTool
{
    [JsonAsset("PCGMetadataMakeTransformSettings")]
    public class UPCGMetadataMakeTransformSettings : UPCGMetadataSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}