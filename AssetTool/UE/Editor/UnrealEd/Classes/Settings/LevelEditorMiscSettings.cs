namespace AssetTool
{
    [JsonAsset("LevelEditorMiscSettings")]
    public class ULevelEditorMiscSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}