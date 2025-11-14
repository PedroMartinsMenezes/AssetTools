namespace AssetTool
{
    [JsonAsset("LyraPlatformEmulationSettings")]
    public class ULyraPlatformEmulationSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}