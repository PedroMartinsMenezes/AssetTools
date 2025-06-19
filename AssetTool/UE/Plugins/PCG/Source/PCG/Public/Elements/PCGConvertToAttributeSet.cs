namespace AssetTool
{
    [JsonAsset("PCGConvertToAttributeSetSettings")]
    public class UPCGConvertToAttributeSetSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGTagsToAttributeSetSettings")]
    public class UPCGTagsToAttributeSetSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}