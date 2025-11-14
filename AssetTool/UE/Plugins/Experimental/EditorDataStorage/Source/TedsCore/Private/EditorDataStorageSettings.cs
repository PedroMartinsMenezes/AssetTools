namespace AssetTool
{
    [JsonAsset("EditorDataStorageSettings")]
    public class UEditorDataStorageSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}