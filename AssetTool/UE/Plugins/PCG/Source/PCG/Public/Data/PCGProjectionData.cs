namespace AssetTool
{
    [JsonAsset("PCGProjectionData")]
    public class UPCGProjectionData : UPCGSpatialDataWithPointCache
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}