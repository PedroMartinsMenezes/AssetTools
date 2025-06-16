namespace AssetTool
{
    [JsonAsset("PCGSortAttributesSettings")]
    public class UPCGSortAttributesSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}