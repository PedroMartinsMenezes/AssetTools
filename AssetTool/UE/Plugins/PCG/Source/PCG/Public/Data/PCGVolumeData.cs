namespace AssetTool
{
    [JsonAsset("PCGVolumeData")]
    public class UPCGVolumeData : UPCGSpatialDataWithPointCache
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}