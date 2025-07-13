namespace AssetTool
{
    [JsonAsset("SecuritySandboxSettings")]
    public class USecuritySandboxSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}