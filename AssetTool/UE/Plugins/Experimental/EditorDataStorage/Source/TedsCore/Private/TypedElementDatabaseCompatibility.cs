namespace AssetTool
{
    [JsonAsset("EditorDataStorageCompatibility")]
    public class UEditorDataStorageCompatibility : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}