namespace AssetTool
{
    [JsonAsset("PCGSplineData")]
    public class UPCGSplineData : UPCGPolyLineData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSplineProjectionData")]
    public class UPCGSplineProjectionData : UPCGProjectionData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}