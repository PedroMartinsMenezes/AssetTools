namespace AssetTool
{
    [JsonAsset("PCGPathfindingSettings")]
    public class UPCGPathfindingSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}