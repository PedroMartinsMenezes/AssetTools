namespace AssetTool
{
    [JsonAsset("PCGSplineData")]
    public class UPCGSplineData : UPCGPolyLineData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSplineProjectionData")]
    public class UPCGSplineProjectionData : UPCGProjectionData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}