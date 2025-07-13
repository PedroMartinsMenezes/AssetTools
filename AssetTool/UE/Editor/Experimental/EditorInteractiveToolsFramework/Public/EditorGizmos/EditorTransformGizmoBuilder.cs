namespace AssetTool
{
    [JsonAsset("EditorTransformGizmoBuilder")]
    public class UEditorTransformGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}