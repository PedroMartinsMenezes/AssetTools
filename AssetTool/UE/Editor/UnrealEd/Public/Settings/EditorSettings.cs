namespace AssetTool
{
    [JsonAsset("EditorSettings")]
    public class UEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}