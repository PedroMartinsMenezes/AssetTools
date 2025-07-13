namespace AssetTool
{
    [JsonAsset("TypedElementBridgeDataStorageFactory")]
    public class UTypedElementBridgeDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}