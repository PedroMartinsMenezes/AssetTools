namespace AssetTool
{
    [JsonAsset("PCGCustomHLSLSettings")]
    public class UPCGCustomHLSLSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}