namespace AssetTool
{
    [JsonAsset("PCGCreateAttributeBaseSettings")]
    public class UPCGCreateAttributeBaseSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGAddAttributeSettings")]
    public class UPCGAddAttributeSettings : UPCGCreateAttributeBaseSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGCreateAttributeSetSettings")]
    public class UPCGCreateAttributeSetSettings : UPCGCreateAttributeBaseSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}