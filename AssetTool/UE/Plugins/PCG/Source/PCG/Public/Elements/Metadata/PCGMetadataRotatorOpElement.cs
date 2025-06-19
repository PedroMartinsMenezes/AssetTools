namespace AssetTool
{
    [JsonAsset("PCGMetadataRotatorSettings")]
    public class UPCGMetadataRotatorSettings : UPCGMetadataSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}