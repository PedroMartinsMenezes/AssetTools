namespace AssetTool
{
    [JsonAsset("EditorDataStorageSettings")]
    public class UEditorDataStorageSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}