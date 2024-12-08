namespace AssetTool
{
    [JsonAsset("DeveloperSettingsBackedByCVars")]
    public class UDeveloperSettingsBackedByCVars : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}