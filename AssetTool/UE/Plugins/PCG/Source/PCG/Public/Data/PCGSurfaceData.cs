namespace AssetTool
{
    [JsonAsset("PCGSurfaceData")]
    public class UPCGSurfaceData : UPCGSpatialDataWithPointCache
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}