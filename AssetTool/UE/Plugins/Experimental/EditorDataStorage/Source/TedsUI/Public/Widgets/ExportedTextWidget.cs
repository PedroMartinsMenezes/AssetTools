namespace AssetTool
{
    [JsonAsset("ExportedTextWidgetFactory")]
    public class UExportedTextWidgetFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}