namespace AssetTool
{
    [JsonAsset("PCGCollapsePointsSettings")]
    public class UPCGCollapsePointsSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}