namespace AssetTool
{
    [JsonAsset("PCGPointData")]
    public class UPCGPointData : UPCGSpatialData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}