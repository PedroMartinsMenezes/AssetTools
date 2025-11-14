namespace AssetTool
{
    [JsonAsset("PCGSortAttributesSettings")]
    public class UPCGSortAttributesSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}