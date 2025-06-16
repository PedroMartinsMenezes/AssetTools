namespace AssetTool
{
    [JsonAsset("PCGTextureSamplerSettings")]
    public class UPCGTextureSamplerSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}