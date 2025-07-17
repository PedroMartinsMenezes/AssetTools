namespace AssetTool
{
    [JsonAsset("LyraPlatformEmulationSettings")]
    public class ULyraPlatformEmulationSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}