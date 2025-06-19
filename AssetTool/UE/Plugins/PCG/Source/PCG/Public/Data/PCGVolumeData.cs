namespace AssetTool
{
    [JsonAsset("PCGVolumeData")]
    public class UPCGVolumeData : UPCGSpatialDataWithPointCache
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}