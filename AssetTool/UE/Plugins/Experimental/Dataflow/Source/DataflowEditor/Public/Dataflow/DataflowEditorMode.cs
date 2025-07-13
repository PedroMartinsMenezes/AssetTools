namespace AssetTool
{
    [JsonAsset("DataflowEditorMode")]
    public class UDataflowEditorMode : UBaseCharacterFXEditorMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}