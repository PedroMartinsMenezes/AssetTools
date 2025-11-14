namespace AssetTool
{
    [JsonAsset("EditorBrushBuilder")]
    public class UEditorBrushBuilder : UBrushBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}