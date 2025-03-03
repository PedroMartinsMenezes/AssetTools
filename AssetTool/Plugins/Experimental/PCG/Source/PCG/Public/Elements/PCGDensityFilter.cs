namespace AssetTool
{
    [JsonAsset("PCGDensityFilterSettings")]
    public class UPCGDensityFilterSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}