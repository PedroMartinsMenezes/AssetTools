namespace AssetTool
{
    [JsonAsset("EditorTransformGizmoSource")]
    public class UEditorTransformGizmoSource : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}