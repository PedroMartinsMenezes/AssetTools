namespace AssetTool
{
    [JsonAsset("EnhancedInputDeveloperSettings")]
    public class UEnhancedInputDeveloperSettings : UDeveloperSettingsBackedByCVars
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}