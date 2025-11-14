namespace AssetTool
{
    [JsonAsset("ModelingToolsEditorModeSettings")]
    public class UModelingToolsEditorModeSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModelingToolsModeCustomizationSettings")]
    public class UModelingToolsModeCustomizationSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}