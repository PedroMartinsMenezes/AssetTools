namespace AssetTool
{
    [JsonAsset("PCGBranchSettings")]
    public class UPCGBranchSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}