namespace AssetTool
{
    [JsonAsset("LevelEditorMiscSettings")]
    public class ULevelEditorMiscSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}