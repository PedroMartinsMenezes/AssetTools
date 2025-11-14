namespace AssetTool
{
    [JsonAsset("DeveloperSettingsBackedByCVars")]
    public class UDeveloperSettingsBackedByCVars : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}