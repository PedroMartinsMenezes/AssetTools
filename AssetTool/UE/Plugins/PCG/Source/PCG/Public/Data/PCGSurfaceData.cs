namespace AssetTool
{
    [JsonAsset("PCGSurfaceData")]
    public class UPCGSurfaceData : UPCGSpatialDataWithPointCache
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}