namespace AssetTool
{
    [JsonAsset("PCGAttributeTransferSettings")]
    public class UPCGAttributeTransferSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}