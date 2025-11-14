namespace AssetTool
{
    [JsonAsset("EditorTransformGizmo")]
    public class UEditorTransformGizmo : UTransformGizmo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}