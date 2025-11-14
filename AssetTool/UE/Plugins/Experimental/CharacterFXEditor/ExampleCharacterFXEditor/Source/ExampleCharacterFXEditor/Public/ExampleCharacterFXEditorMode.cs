namespace AssetTool
{
    [JsonAsset("ExampleCharacterFXEditorMode")]
    public class UExampleCharacterFXEditorMode : UBaseCharacterFXEditorMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}