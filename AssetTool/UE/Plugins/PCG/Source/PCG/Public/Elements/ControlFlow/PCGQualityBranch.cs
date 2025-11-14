namespace AssetTool
{
    [JsonAsset("PCGQualityBranchSettings")]
    public class UPCGQualityBranchSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}