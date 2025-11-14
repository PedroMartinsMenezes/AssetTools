namespace AssetTool
{
    [JsonAsset("PCGPolyLineData")]
    public class UPCGPolyLineData : UPCGSpatialDataWithPointCache
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}