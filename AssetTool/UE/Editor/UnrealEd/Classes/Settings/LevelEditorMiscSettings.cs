namespace AssetTool
{
    [JsonAsset("LevelEditorMiscSettings")]
    public class ULevelEditorMiscSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}