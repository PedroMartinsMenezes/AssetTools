namespace AssetTool
{
    [JsonAsset("LevelEditorSubsystem")]
    public class ULevelEditorSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}