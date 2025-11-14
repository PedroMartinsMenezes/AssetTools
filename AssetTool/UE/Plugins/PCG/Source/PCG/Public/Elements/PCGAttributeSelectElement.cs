namespace AssetTool
{
    [JsonAsset("PCGAttributeSelectSettings")]
    public class UPCGAttributeSelectSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}