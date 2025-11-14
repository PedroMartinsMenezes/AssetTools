namespace AssetTool
{
    [JsonAsset("PCGConvertToAttributeSetSettings")]
    public class UPCGConvertToAttributeSetSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGTagsToAttributeSetSettings")]
    public class UPCGTagsToAttributeSetSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}