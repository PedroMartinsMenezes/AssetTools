namespace AssetTool
{
    [JsonAsset("TypedElementTableViewerFactory")]
    public class UTypedElementTableViewerFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}