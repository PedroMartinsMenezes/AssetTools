namespace AssetTool
{
    [JsonAsset("PCGBasePointData")]
    public class UPCGBasePointData : UPCGSpatialData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}