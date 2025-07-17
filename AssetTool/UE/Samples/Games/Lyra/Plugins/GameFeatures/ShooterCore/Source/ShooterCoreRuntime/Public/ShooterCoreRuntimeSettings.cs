namespace AssetTool
{
    [JsonAsset("ShooterCoreRuntimeSettings")]
    public class UShooterCoreRuntimeSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}