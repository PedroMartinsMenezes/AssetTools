namespace AssetTool
{
    [JsonAsset("LevelInstanceEditorBehaviorSource")]
    public class ULevelInstanceEditorBehaviorSource : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelInstanceEditorMode")]
    public class ULevelInstanceEditorMode : UEdMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}