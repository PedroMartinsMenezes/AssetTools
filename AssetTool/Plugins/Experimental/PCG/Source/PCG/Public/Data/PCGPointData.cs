namespace AssetTool
{
    [JsonAsset("PCGPointData")]
    public class UPCGPointData : UPCGSpatialData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}