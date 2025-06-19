namespace AssetTool
{
    [JsonAsset("DeveloperSettingsBackedByCVars")]
    public class UDeveloperSettingsBackedByCVars : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}