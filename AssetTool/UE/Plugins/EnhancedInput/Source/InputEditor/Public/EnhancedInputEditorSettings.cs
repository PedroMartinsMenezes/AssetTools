namespace AssetTool
{
    [JsonAsset("EnhancedInputEditorProjectSettings")]
    public class UEnhancedInputEditorProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EnhancedInputEditorSettings")]
    public class UEnhancedInputEditorSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}