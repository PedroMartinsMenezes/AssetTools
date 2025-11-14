namespace AssetTool
{
    [JsonAsset("PCGIntersectionData")]
    public class UPCGIntersectionData : UPCGSpatialDataWithPointCache
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}