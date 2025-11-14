namespace AssetTool
{
    [JsonAsset("PCGUnionData")]
    public class UPCGUnionData : UPCGSpatialDataWithPointCache
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}