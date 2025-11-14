namespace AssetTool
{
    [JsonAsset("PCGProjectionData")]
    public class UPCGProjectionData : UPCGSpatialDataWithPointCache
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}