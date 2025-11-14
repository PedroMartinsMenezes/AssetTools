namespace AssetTool
{
    [JsonAsset("LevelInstanceEditorBehaviorSource")]
    public class ULevelInstanceEditorBehaviorSource : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelInstanceEditorMode")]
    public class ULevelInstanceEditorMode : UEdMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}