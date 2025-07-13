namespace AssetTool
{
    [JsonAsset("EditorDataStorageFactory")]
    public class UEditorDataStorageFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}