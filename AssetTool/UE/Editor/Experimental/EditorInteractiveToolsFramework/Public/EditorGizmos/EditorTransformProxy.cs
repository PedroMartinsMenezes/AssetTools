namespace AssetTool
{
    [JsonAsset("EditorTransformProxy")]
    public class UEditorTransformProxy : UTransformProxy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}