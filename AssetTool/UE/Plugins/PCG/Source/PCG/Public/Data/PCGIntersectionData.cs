namespace AssetTool
{
    [JsonAsset("PCGIntersectionData")]
    public class UPCGIntersectionData : UPCGSpatialDataWithPointCache
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}