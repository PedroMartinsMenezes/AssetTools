namespace AssetTool
{
    [JsonAsset("PCGGetTagsSettings")]
    public class UPCGGetTagsSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGGetAttributesSettings")]
    public class UPCGGetAttributesSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}