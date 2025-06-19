namespace AssetTool
{
    [JsonAsset("PCGQualityBranchSettings")]
    public class UPCGQualityBranchSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}