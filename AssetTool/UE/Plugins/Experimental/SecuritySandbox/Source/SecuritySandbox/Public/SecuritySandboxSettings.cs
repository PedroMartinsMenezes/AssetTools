namespace AssetTool
{
    [JsonAsset("SecuritySandboxSettings")]
    public class USecuritySandboxSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}