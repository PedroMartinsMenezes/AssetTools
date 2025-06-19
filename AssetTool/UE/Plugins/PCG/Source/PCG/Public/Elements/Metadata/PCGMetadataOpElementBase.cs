namespace AssetTool
{
    [JsonAsset("PCGMetadataSettingsBase")]
    public class UPCGMetadataSettingsBase : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}