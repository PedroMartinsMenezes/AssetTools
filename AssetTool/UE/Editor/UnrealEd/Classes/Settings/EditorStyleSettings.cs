namespace AssetTool
{
    [JsonAsset("EditorStyleSettings")]
    public class UEditorStyleSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}