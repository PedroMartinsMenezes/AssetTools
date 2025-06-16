namespace AssetTool
{
    [JsonAsset("PCGSanityCheckPointDataSettings")]
    public class UPCGSanityCheckPointDataSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}