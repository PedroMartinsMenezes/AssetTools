namespace AssetTool
{
    [JsonAsset("EditorTransformProxy")]
    public class UEditorTransformProxy : UTransformProxy
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}