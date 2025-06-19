namespace AssetTool
{
    [JsonAsset("PCGAddAttributeSettings")]
    public class UPCGAddAttributeSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGCreateAttributeSetSettings")]
    public class UPCGCreateAttributeSetSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}