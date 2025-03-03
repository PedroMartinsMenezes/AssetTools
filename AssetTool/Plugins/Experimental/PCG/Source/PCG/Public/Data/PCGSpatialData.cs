namespace AssetTool
{
    [JsonAsset("PCGSpatialData")]
    public class UPCGSpatialData : UPCGData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSpatialDataWithPointCache")]
    public class UPCGSpatialDataWithPointCache : UPCGSpatialData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}