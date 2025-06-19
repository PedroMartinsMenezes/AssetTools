namespace AssetTool
{
    [JsonAsset("EditorBrushBuilder")]
    public class UEditorBrushBuilder : UBrushBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}