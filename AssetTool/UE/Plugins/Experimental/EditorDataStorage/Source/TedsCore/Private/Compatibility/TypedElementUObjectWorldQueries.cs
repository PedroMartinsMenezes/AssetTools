namespace AssetTool
{
    [JsonAsset("ObjectWorldDataStorageFactory")]
    public class UObjectWorldDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}