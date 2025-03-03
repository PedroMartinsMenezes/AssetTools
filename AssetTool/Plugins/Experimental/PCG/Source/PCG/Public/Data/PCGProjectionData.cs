namespace AssetTool
{
    [JsonAsset("PCGProjectionData")]
    public class UPCGProjectionData : UPCGSpatialDataWithPointCache
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}