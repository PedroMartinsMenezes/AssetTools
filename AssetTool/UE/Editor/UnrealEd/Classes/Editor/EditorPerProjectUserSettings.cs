namespace AssetTool
{
    [JsonAsset("EditorPerProjectUserSettings")]
    public class UEditorPerProjectUserSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}