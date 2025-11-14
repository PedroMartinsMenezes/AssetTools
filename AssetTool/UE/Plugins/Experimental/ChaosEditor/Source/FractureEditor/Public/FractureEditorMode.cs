namespace AssetTool
{
    [JsonAsset("FractureEditorMode")]
    public class UFractureEditorMode : UBaseLegacyWidgetEdMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureModeCustomizationSettings")]
    public class UFractureModeCustomizationSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}