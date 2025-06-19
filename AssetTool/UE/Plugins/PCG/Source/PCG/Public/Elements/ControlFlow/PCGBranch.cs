namespace AssetTool
{
    [JsonAsset("PCGBranchSettings")]
    public class UPCGBranchSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}