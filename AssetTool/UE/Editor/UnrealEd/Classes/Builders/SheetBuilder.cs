namespace AssetTool
{
    [JsonAsset("SheetBuilder")]
    public class USheetBuilder : UEditorBrushBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}