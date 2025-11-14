namespace AssetTool
{
    [JsonAsset("PCGSelectPointsSettings")]
    public class UPCGSelectPointsSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}