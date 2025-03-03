namespace AssetTool
{
    [JsonAsset("PCGSurfaceData")]
    public class UPCGSurfaceData : UPCGSpatialDataWithPointCache
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}