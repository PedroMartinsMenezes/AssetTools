namespace AssetTool
{
    [JsonAsset("PCGCollapseSettings")]
    public class UPCGCollapseSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGConvertToPointDataSettings")]
    public class UPCGConvertToPointDataSettings : UPCGCollapseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}