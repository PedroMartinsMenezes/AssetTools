namespace AssetTool
{
    [JsonAsset("LevelEditorViewportSettings")]
    public class ULevelEditorViewportSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}