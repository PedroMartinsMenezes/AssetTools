namespace AssetTool
{
    [JsonAsset("PCGUnionData")]
    public class UPCGUnionData : UPCGSpatialDataWithPointCache
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}