namespace AssetTool
{
    [JsonAsset("LevelEditorViewportSettings")]
    public class ULevelEditorViewportSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}