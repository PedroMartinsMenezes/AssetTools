namespace AssetTool
{
    [JsonAsset("SlateVisualizationWidgetFactory")]
    public class USlateVisualizationWidgetFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}