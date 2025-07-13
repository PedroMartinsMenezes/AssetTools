namespace AssetTool
{
    [JsonAsset("EnhancedInputEditorProjectSettings")]
    public class UEnhancedInputEditorProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EnhancedInputEditorSettings")]
    public class UEnhancedInputEditorSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}