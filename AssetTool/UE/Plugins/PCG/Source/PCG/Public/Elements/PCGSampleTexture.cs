namespace AssetTool
{
    [JsonAsset("PCGSampleTextureSettings")]
    public class UPCGSampleTextureSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}