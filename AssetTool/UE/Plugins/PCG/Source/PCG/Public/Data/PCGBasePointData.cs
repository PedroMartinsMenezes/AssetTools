namespace AssetTool
{
    [JsonAsset("PCGBasePointData")]
    public class UPCGBasePointData : UPCGSpatialData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}