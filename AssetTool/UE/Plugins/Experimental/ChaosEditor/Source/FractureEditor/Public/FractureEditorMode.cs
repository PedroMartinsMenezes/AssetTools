namespace AssetTool
{
    [JsonAsset("FractureEditorMode")]
    public class UFractureEditorMode : UBaseLegacyWidgetEdMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureModeCustomizationSettings")]
    public class UFractureModeCustomizationSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}