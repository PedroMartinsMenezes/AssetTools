namespace AssetTool
{
    [JsonAsset("ToolPresetUserSettings")]
    public class UToolPresetUserSettings : UEditorConfigBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ToolPresetProjectSettings")]
    public class UToolPresetProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}