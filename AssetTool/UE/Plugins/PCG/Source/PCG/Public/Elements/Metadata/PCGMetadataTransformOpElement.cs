namespace AssetTool
{
    [JsonAsset("PCGMetadataTransformSettings")]
    public class UPCGMetadataTransformSettings : UPCGMetadataSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}