namespace AssetTool
{
    [JsonAsset("EditorTransformGizmoSource")]
    public class UEditorTransformGizmoSource : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}