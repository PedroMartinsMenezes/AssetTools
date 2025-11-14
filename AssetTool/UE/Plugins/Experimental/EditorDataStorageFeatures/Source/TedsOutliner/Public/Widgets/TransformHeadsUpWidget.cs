namespace AssetTool
{
    [JsonAsset("TransformHeadsUpWidgetFactory")]
    public class UTransformHeadsUpWidgetFactory : UEditorDataStorageFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}