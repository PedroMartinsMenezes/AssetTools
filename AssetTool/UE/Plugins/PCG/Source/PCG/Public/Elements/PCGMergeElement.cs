namespace AssetTool
{
    [JsonAsset("PCGMergeSettings")]
    public class UPCGMergeSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}