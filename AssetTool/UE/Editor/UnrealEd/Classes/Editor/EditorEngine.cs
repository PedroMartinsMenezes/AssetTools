namespace AssetTool
{
    [JsonAsset("EditorEngine")]
    public class UEditorEngine : UEngine
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}