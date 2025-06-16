namespace AssetTool
{
    [JsonAsset("PCGQualityBranchSettings")]
    public class UPCGQualityBranchSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}