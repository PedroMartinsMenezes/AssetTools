namespace AssetTool
{
    [JsonAsset("ExampleCharacterFXEditorSubsystem")]
    public class UExampleCharacterFXEditorSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}