namespace AssetTool
{
    [JsonAsset("PCGCollapsePointsSettings")]
    public class UPCGCollapsePointsSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}