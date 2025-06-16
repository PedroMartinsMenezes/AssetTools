namespace AssetTool
{
    [JsonAsset("PCGAttributeFilteringSettings")]
    public class UPCGAttributeFilteringSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGAttributeFilteringRangeSettings")]
    public class UPCGAttributeFilteringRangeSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}