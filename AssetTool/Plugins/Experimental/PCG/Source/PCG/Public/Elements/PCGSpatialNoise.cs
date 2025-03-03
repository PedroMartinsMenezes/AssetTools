namespace AssetTool
{
    [JsonAsset("PCGSpatialNoiseSettings")]
    public class UPCGSpatialNoiseSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}