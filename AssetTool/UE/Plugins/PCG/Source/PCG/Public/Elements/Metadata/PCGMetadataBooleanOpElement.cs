namespace AssetTool
{
    [JsonAsset("PCGMetadataBooleanSettings")]
    public class UPCGMetadataBooleanSettings : UPCGMetadataSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}