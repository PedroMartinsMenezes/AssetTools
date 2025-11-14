namespace AssetTool
{
    [JsonAsset("PCGPathfindingSettings")]
    public class UPCGPathfindingSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}