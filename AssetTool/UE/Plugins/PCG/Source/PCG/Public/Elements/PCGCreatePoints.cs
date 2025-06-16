namespace AssetTool
{
    [JsonAsset("PCGCreatePointsSettings")]
    public class UPCGCreatePointsSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}