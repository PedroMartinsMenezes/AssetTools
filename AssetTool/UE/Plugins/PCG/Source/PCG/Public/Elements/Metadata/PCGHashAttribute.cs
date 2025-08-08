namespace AssetTool
{
    [JsonAsset("PCGHashAttributeSettings")]
    public class UPCGHashAttributeSettings : UPCGMetadataSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}