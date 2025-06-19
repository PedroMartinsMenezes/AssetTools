namespace AssetTool
{
    [JsonAsset("PCGMetadataBitwiseSettings")]
    public class UPCGMetadataBitwiseSettings : UPCGMetadataSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}