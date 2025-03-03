namespace AssetTool
{
    [JsonAsset("PCGNumberOfPointsSettings")]
    public class UPCGNumberOfPointsSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}