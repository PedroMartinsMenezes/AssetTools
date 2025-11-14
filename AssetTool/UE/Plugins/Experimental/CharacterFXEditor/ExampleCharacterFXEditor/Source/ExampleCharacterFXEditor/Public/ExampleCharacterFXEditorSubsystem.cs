namespace AssetTool
{
    [JsonAsset("ExampleCharacterFXEditorSubsystem")]
    public class UExampleCharacterFXEditorSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}