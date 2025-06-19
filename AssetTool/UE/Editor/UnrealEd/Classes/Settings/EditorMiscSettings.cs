namespace AssetTool
{
    [JsonAsset("EditorMiscSettings")]
    public class UEditorMiscSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}