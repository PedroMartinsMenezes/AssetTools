namespace AssetTool
{
    [JsonAsset("EditorEngine")]
    public class UEditorEngine : UEngine
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}