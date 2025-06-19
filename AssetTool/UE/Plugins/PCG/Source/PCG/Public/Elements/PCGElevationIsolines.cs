namespace AssetTool
{
    [JsonAsset("PCGElevationIsolinesSettings")]
    public class UPCGElevationIsolinesSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}