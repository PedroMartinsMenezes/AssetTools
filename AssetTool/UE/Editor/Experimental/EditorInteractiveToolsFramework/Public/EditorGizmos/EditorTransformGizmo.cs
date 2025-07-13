namespace AssetTool
{
    [JsonAsset("EditorTransformGizmo")]
    public class UEditorTransformGizmo : UTransformGizmo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}