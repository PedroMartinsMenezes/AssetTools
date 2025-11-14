namespace AssetTool
{
    [JsonAsset("PCGCollapsePointsSettings")]
    public class UPCGCollapsePointsSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}