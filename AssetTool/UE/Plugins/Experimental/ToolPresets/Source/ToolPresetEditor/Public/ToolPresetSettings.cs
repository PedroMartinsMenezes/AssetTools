namespace AssetTool
{
    [JsonAsset("ToolPresetUserSettings")]
    public class UToolPresetUserSettings : UEditorConfigBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ToolPresetProjectSettings")]
    public class UToolPresetProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}