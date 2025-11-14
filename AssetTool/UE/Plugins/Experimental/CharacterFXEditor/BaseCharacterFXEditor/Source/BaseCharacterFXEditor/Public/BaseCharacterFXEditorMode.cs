namespace AssetTool
{
    [JsonAsset("BaseCharacterFXEditorMode")]
    public class UBaseCharacterFXEditorMode : UEdMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}