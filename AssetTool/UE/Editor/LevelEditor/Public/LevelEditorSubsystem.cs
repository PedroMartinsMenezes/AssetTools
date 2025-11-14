namespace AssetTool
{
    [JsonAsset("LevelEditorSubsystem")]
    public class ULevelEditorSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}