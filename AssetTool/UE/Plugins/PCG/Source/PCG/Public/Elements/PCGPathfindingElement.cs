namespace AssetTool
{
    [JsonAsset("PCGPathfindingSettings")]
    public class UPCGPathfindingSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}