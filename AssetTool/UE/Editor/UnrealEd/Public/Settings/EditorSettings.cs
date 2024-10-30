namespace AssetTool
{
    [JsonAsset("EditorSettings")]
    public class UEditorSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}