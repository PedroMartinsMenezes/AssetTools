namespace AssetTool
{
    [JsonAsset("PCGSortAttributesSettings")]
    public class UPCGSortAttributesSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}