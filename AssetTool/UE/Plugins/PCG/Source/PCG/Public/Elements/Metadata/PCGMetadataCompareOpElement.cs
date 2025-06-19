namespace AssetTool
{
    [JsonAsset("PCGMetadataCompareSettings")]
    public class UPCGMetadataCompareSettings : UPCGMetadataSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}