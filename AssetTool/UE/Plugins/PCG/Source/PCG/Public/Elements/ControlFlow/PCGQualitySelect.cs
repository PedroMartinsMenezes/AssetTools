namespace AssetTool
{
    [JsonAsset("PCGQualitySelectSettings")]
    public class UPCGQualitySelectSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}