namespace AssetTool
{
    [JsonAsset("PCGPolyLineData")]
    public class UPCGPolyLineData : UPCGSpatialDataWithPointCache
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}