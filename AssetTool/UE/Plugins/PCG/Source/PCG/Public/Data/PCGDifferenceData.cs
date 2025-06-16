namespace AssetTool
{
    [JsonAsset("PCGDifferenceData")]
    public class UPCGDifferenceData : UPCGSpatialDataWithPointCache
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}