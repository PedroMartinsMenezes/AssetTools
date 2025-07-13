namespace AssetTool
{
    [JsonAsset("TypedElementActorHandleDataStorageFactory")]
    public class UTypedElementActorHandleDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}