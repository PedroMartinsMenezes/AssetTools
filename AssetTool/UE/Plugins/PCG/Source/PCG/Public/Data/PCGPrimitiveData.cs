namespace AssetTool
{
    [JsonAsset("PCGPrimitiveData")]
    public class UPCGPrimitiveData : UPCGSpatialDataWithPointCache
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}