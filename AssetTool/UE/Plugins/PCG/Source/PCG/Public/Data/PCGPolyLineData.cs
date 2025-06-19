namespace AssetTool
{
    [JsonAsset("PCGPolyLineData")]
    public class UPCGPolyLineData : UPCGSpatialDataWithPointCache
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}