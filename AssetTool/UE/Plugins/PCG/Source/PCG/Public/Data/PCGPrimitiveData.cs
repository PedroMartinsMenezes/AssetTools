namespace AssetTool
{
    [JsonAsset("PCGPrimitiveData")]
    public class UPCGPrimitiveData : UPCGSpatialDataWithPointCache
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}