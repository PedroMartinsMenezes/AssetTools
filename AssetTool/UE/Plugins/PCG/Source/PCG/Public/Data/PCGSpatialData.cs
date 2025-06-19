namespace AssetTool
{
    [JsonAsset("PCGSpatialData")]
    public class UPCGSpatialData : UPCGData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSpatialDataWithPointCache")]
    public class UPCGSpatialDataWithPointCache : UPCGSpatialData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}