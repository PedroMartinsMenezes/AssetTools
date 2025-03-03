namespace AssetTool
{
    [JsonAsset("PCGSurfaceSamplerSettings")]
    public class UPCGSurfaceSamplerSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}