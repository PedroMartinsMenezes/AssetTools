namespace AssetTool
{
    [JsonAsset("PCGSelectPointsSettings")]
    public class UPCGSelectPointsSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}