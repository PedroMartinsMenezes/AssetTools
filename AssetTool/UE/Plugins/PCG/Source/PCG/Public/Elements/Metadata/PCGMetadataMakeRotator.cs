namespace AssetTool
{
    [JsonAsset("PCGMetadataMakeRotatorSettings")]
    public class UPCGMetadataMakeRotatorSettings : UPCGMetadataSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}