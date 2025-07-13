namespace AssetTool
{
    [JsonAsset("ExampleCharacterFXEditorUISubsystem")]
    public class UExampleCharacterFXEditorUISubsystem : UBaseCharacterFXEditorUISubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}