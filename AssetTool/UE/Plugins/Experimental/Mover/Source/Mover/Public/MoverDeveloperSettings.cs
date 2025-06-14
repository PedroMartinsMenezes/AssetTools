namespace AssetTool
{
    [JsonAsset("MoverDeveloperSettings")]
    public class UMoverDeveloperSettings : UDeveloperSettingsBackedByCVars
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}