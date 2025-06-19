namespace AssetTool
{
    [JsonAsset("SheetBuilder")]
    public class USheetBuilder : UEditorBrushBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}