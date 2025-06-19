namespace AssetTool
{
    [JsonAsset("PCGSurfaceSamplerSettings")]
    public class UPCGSurfaceSamplerSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}