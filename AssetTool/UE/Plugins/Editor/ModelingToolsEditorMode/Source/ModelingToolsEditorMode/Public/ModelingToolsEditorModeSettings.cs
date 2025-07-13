namespace AssetTool
{
    [JsonAsset("ModelingToolsEditorModeSettings")]
    public class UModelingToolsEditorModeSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModelingToolsModeCustomizationSettings")]
    public class UModelingToolsModeCustomizationSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}