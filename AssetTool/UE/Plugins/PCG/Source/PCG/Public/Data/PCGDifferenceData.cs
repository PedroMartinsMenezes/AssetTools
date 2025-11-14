namespace AssetTool
{
    [JsonAsset("PCGDifferenceData")]
    public class UPCGDifferenceData : UPCGSpatialDataWithPointCache
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}