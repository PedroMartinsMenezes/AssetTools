namespace AssetTool
{
    [JsonAsset("PCGSurfaceSamplerSettings")]
    public class UPCGSurfaceSamplerSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}