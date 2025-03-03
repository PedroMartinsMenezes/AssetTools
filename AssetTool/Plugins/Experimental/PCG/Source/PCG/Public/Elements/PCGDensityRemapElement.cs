namespace AssetTool
{
    [JsonAsset("PCGDensityRemapSettings")]
    public class UPCGDensityRemapSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}