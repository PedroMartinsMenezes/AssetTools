namespace AssetTool
{
    [JsonAsset("LabelWidgetFactory")]
    public class ULabelWidgetFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}