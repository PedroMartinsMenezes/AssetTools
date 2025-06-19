namespace AssetTool
{
    [JsonAsset("PCGIntersectionData")]
    public class UPCGIntersectionData : UPCGSpatialDataWithPointCache
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}