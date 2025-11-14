namespace AssetTool
{
    [JsonAsset("EditorPerProjectUserSettings")]
    public class UEditorPerProjectUserSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}