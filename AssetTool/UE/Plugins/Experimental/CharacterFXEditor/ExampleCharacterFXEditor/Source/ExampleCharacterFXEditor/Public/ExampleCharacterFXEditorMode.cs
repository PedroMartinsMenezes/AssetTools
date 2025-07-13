namespace AssetTool
{
    [JsonAsset("ExampleCharacterFXEditorMode")]
    public class UExampleCharacterFXEditorMode : UBaseCharacterFXEditorMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}