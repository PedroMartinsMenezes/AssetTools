namespace AssetTool
{
    [JsonAsset("PCGSampleTextureSettings")]
    public class UPCGSampleTextureSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}