namespace AssetTool
{
    [JsonAsset("CounterWidgetFactory")]
    public class UCounterWidgetFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}