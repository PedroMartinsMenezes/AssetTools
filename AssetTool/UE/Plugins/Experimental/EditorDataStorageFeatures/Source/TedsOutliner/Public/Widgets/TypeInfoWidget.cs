namespace AssetTool
{
    [JsonAsset("TypeInfoWidgetFactory")]
    public class UTypeInfoWidgetFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}