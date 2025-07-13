namespace AssetTool
{
    [JsonAsset("TransformHeadsUpWidgetFactory")]
    public class UTransformHeadsUpWidgetFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}