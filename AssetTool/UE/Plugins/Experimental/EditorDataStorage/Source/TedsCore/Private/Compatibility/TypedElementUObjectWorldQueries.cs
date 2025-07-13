namespace AssetTool
{
    [JsonAsset("ObjectWorldDataStorageFactory")]
    public class UObjectWorldDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}