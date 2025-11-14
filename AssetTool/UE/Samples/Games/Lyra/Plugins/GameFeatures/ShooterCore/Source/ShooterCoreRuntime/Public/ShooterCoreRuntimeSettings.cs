namespace AssetTool
{
    [JsonAsset("ShooterCoreRuntimeSettings")]
    public class UShooterCoreRuntimeSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}