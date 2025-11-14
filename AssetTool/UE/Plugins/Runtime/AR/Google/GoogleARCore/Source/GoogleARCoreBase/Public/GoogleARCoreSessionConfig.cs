namespace AssetTool
{
    [JsonAsset("GoogleARCoreSessionConfig")]
    public class UGoogleARCoreSessionConfig : UARSessionConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}