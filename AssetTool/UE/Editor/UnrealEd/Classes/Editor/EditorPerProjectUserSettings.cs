namespace AssetTool
{
    [JsonAsset("EditorPerProjectUserSettings")]
    public class UEditorPerProjectUserSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}