namespace AssetTool
{
    [JsonAsset("PCGSplineData")]
    public class UPCGSplineData : UPCGPolyLineData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSplineProjectionData")]
    public class UPCGSplineProjectionData : UPCGProjectionData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}