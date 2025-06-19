namespace AssetTool
{
    [JsonAsset("PCGMetadataTrigSettings")]
    public class UPCGMetadataTrigSettings : UPCGMetadataSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}