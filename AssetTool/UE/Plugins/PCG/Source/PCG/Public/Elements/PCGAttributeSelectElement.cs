namespace AssetTool
{
    [JsonAsset("PCGAttributeSelectSettings")]
    public class UPCGAttributeSelectSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}