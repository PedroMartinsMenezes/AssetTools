namespace AssetTool
{
    [JsonAsset("PCGBranchSettings")]
    public class UPCGBranchSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}