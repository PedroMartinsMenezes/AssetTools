namespace AssetTool
{
    [JsonAsset("PCGMetadataRotatorSettings")]
    public class UPCGMetadataRotatorSettings : UPCGMetadataSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}