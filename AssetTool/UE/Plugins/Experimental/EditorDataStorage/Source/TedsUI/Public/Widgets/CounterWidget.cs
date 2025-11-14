namespace AssetTool
{
    [JsonAsset("CounterWidgetFactory")]
    public class UCounterWidgetFactory : UEditorDataStorageFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}