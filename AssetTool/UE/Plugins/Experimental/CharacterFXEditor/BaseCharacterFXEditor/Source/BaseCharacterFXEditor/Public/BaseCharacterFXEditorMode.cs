namespace AssetTool
{
    [JsonAsset("BaseCharacterFXEditorMode")]
    public class UBaseCharacterFXEditorMode : UEdMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}