namespace AssetTool
{
    [JsonAsset("PCGTextureSamplerSettings")]
    public class UPCGTextureSamplerSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}