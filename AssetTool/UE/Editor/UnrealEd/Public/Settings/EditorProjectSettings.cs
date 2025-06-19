namespace AssetTool
{
    [JsonAsset("EditorProjectAppearanceSettings")]
    public class UEditorProjectAppearanceSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelEditor2DSettings")]
    public class ULevelEditor2DSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelEditorProjectSettings")]
    public class ULevelEditorProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditorPerformanceProjectSettings")]
    public class UEditorPerformanceProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DDCProjectSettings")]
    public class UDDCProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}