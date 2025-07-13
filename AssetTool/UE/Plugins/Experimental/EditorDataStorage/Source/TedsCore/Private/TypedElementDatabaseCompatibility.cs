namespace AssetTool
{
    [JsonAsset("EditorDataStorageCompatibility")]
    public class UEditorDataStorageCompatibility : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}