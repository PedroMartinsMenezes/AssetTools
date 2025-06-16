namespace AssetTool
{
    [JsonAsset("PCGSampleTextureSettings")]
    public class UPCGSampleTextureSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}