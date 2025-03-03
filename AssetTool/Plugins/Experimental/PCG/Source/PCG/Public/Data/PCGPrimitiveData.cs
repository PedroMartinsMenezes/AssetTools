namespace AssetTool
{
    [JsonAsset("PCGPrimitiveData")]
    public class UPCGPrimitiveData : UPCGSpatialDataWithPointCache
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}