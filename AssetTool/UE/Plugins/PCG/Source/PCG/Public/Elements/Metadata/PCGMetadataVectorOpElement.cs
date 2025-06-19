namespace AssetTool
{
    [JsonAsset("PCGMetadataVectorSettings")]
    public class UPCGMetadataVectorSettings : UPCGMetadataSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}