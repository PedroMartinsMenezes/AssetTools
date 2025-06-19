namespace AssetTool
{
    [JsonAsset("PCGUnionData")]
    public class UPCGUnionData : UPCGSpatialDataWithPointCache
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}