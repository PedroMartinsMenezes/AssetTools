namespace AssetTool
{
    [JsonAsset("PCGDensityFilterSettings")]
    public class UPCGDensityFilterSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}