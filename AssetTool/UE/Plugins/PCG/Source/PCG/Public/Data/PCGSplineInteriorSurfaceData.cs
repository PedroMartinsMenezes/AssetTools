namespace AssetTool
{
    [JsonAsset("PCGSplineInteriorSurfaceData")]
    public class UPCGSplineInteriorSurfaceData : UPCGSurfaceData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}