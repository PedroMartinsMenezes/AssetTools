namespace AssetTool
{
    [JsonAsset("PCGPointData")]
    public class UPCGPointData : UPCGSpatialData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}