namespace AssetTool
{
    [JsonAsset("PCGConvertToAttributeSetSettings")]
    public class UPCGConvertToAttributeSetSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGTagsToAttributeSetSettings")]
    public class UPCGTagsToAttributeSetSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}