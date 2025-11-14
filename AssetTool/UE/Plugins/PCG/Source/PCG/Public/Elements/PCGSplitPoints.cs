namespace AssetTool
{
    [JsonAsset("PCGSplitPointsSettings")]
    public class UPCGSplitPointsSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}