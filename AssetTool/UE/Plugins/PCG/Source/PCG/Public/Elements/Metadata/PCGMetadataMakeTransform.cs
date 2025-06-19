namespace AssetTool
{
    [JsonAsset("PCGMetadataMakeTransformSettings")]
    public class UPCGMetadataMakeTransformSettings : UPCGMetadataSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}