namespace AssetTool
{
    [JsonAsset("PCGSpatialNoiseSettings")]
    public class UPCGSpatialNoiseSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}