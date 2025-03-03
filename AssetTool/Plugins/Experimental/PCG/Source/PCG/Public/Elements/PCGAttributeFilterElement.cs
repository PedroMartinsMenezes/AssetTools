namespace AssetTool
{
    [JsonAsset("PCGAttributeFilterSettings")]
    public class UPCGAttributeFilterSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}