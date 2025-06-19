namespace AssetTool
{
    [JsonAsset("EnhancedInputDeveloperSettings")]
    public class UEnhancedInputDeveloperSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}