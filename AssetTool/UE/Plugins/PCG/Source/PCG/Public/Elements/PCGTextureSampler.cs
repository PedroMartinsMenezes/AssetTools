namespace AssetTool
{
    [JsonAsset("PCGTextureSamplerSettings")]
    public class UPCGTextureSamplerSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}