namespace AssetTool
{
    [JsonAsset("GoogleARCoreSessionConfig")]
    public class UGoogleARCoreSessionConfig : UARSessionConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}