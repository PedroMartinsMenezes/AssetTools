namespace AssetTool
{
    [JsonAsset("LevelInstanceEditorSettings")]
    public class ULevelInstanceEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelInstanceEditorPerProjectUserSettings")]
    public class ULevelInstanceEditorPerProjectUserSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}