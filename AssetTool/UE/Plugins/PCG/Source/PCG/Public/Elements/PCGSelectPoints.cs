namespace AssetTool
{
    [JsonAsset("PCGSelectPointsSettings")]
    public class UPCGSelectPointsSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}