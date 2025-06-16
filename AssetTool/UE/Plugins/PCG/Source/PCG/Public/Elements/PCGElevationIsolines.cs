namespace AssetTool
{
    [JsonAsset("PCGElevationIsolinesSettings")]
    public class UPCGElevationIsolinesSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}