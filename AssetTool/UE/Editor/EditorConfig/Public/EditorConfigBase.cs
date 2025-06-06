namespace AssetTool
{
    [JsonAsset("EditorConfigBase")]
    public class UEditorConfigBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}