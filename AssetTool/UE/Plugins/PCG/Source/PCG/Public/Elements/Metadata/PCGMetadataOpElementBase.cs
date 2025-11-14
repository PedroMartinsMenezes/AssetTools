namespace AssetTool
{
    [JsonAsset("PCGMetadataSettingsBase")]
    public class UPCGMetadataSettingsBase : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}