namespace AssetTool
{
    [JsonAsset("EditorConfigBase")]
    public class UEditorConfigBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}