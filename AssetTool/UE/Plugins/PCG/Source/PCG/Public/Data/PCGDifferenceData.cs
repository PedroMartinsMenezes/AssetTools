namespace AssetTool
{
    [JsonAsset("PCGDifferenceData")]
    public class UPCGDifferenceData : UPCGSpatialDataWithPointCache
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}